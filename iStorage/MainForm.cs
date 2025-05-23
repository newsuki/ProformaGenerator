﻿using com.itextpdf.text.pdf;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iStorage
{
    public partial class MainForm : Form
    {
        private Database db;
        public ItemsForm itemsForm;

        public double totalInvoicePrice = 0;

        private readonly Random random = new Random();
        public MainForm()
        {
            InitializeComponent();

            db = new Database();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = 2;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void companySettingsPicture_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuyersForm buyersForm = new BuyersForm(this);
            buyersForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            itemsForm = new ItemsForm(this);
            itemsForm.Show();
        }

        private void selectCompanyButton_Click(object sender, EventArgs e)
        {
            SellerForm sellerForm = new SellerForm(this);
            sellerForm.Show();
        }

        private void clearInvoiceListboxes_Click(object sender, EventArgs e)
        {
            sellerRichTextbox.Clear();
            buyerRichTextbox.Clear();
            invoiceProductsListbox.Items.Clear();

            totalInvoicePrice = 0.00;
            label6.Text = "Total: " + totalInvoicePrice;
        }

        public void AddSelectedItemsToListBox(List<string> items, ListBox listBox)
        {
            foreach (string item in items)
            {
                string formattedItem = item.Replace("|", Environment.NewLine);
                listBox.Items.Add(formattedItem);
            }
        }

        private void createInvoiceButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(sellerRichTextbox.Text) ||
                string.IsNullOrWhiteSpace(buyerRichTextbox.Text) ||
                invoiceProductsListbox.Items.Count == 0)
            {
                MessageBox.Show("Buyer, seller, or item entries are empty!");
                return;
            }

            db.Open();

            int year = DateTime.Now.Year;
            string invoiceNumber = db.GenerateInvoiceNumber(year); 

            var listBoxData = invoiceProductsListbox.Items
                    .Cast<InvoiceItem>()
                    .Select(item => $"{item.ItemName} ({item.Quantity})\n{item.ItemDescription}\n{item.TotalPrice:#0.##}")
                    .ToList();

            string richTextBox1Data = buyerRichTextbox.Text;
            string richTextBox2Data = sellerRichTextbox.Text;

            db.CreateProforma(sellerRichTextbox, buyerRichTextbox, invoiceProductsListbox, dateTimePicker1.Value.ToString(), invoiceNumber, totalInvoicePrice);

            db.Close();
        }


        private void excelButton_Click(object sender, EventArgs e)
        {
            db.ExportToExcel(comboBox2.SelectedItem.ToString());
        }

        private void invoiceBuyerListbox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (e.Index < 0) return;

            ListBox listBox = sender as ListBox;
            string itemText = listBox.Items[e.Index].ToString();
            SizeF textSize = e.Graphics.MeasureString(itemText, listBox.Font, listBox.Width);
            e.ItemHeight = (int)textSize.Height;
        }

        private void invoiceBuyerListbox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();
            ListBox listBox = sender as ListBox;
            string itemText = listBox.Items[e.Index].ToString();
            using (Brush textBrush = new SolidBrush(e.ForeColor))
            {
                e.Graphics.DrawString(itemText, listBox.Font, textBrush, e.Bounds);
            }
            e.DrawFocusRectangle();
        }

        private void invoiceProductsListbox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();
            ListBox listBox = sender as ListBox;
            string itemText = listBox.Items[e.Index].ToString();
            using (Brush textBrush = new SolidBrush(e.ForeColor))
            {
                e.Graphics.DrawString(itemText, listBox.Font, textBrush, e.Bounds);
            }
            e.DrawFocusRectangle();
        }

        private void invoiceProductsListbox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (e.Index < 0) return;

            ListBox listBox = sender as ListBox;
            string itemText = listBox.Items[e.Index].ToString();
            SizeF textSize = e.Graphics.MeasureString(itemText, listBox.Font, listBox.Width);
            e.ItemHeight = (int)textSize.Height;
        }

        private void invoiceSellerListbox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();
            ListBox listBox = sender as ListBox;
            string itemText = listBox.Items[e.Index].ToString();
            using (Brush textBrush = new SolidBrush(e.ForeColor))
            {
                e.Graphics.DrawString(itemText, listBox.Font, textBrush, e.Bounds);
            }
            e.DrawFocusRectangle();
        }

        private void invoiceSellerListbox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (e.Index < 0) return;

            ListBox listBox = sender as ListBox;
            string itemText = listBox.Items[e.Index].ToString();
            SizeF textSize = e.Graphics.MeasureString(itemText, listBox.Font, listBox.Width);
            e.ItemHeight = (int)textSize.Height;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (invoiceProductsListbox.SelectedIndex != -1)
            {
                var selectedItem = invoiceProductsListbox.SelectedItem;

                if (selectedItem is InvoiceItem invoiceItem)
                {
                    totalInvoicePrice -= invoiceItem.TotalPrice;
                }
                else
                {
                    // It's probably a string, so we can't modify the total
                    MessageBox.Show("This item is from a historical invoice and cannot be modified.");
                }

                invoiceProductsListbox.Items.RemoveAt(invoiceProductsListbox.SelectedIndex);
                label6.Text = "Total: " + totalInvoicePrice.ToString("0.00", CultureInfo.InvariantCulture);
            }
        }


        private void proformaHistoryButton_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm();
            historyForm.Show();
        }
    }
}
