using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iStorage
{
    public partial class MainForm : Form
    {
        private Database db;

        private readonly Random random = new Random();
        public MainForm()
        {
            InitializeComponent();

            db = new Database();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
            comboBox2.SelectedIndex = 2;    
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
            ItemsForm itemsForm = new ItemsForm(this);
            itemsForm.Show();
        }

        private void selectCompanyButton_Click(object sender, EventArgs e)
        {
            SellerForm sellerForm = new SellerForm(this);
            sellerForm.Show();
        }

        private void clearInvoiceListboxes_Click(object sender, EventArgs e)
        {
            invoiceBuyerListbox.Items.Clear();
            invoiceSellerListbox.Items.Clear();
            invoiceProductsListbox.Items.Clear();
        }

        public void AddSelectedItemsToListBox(List<string> items, ListBox listBox)
        {
            foreach (string item in items)
            {
                string[] splitItems = item.Split('|');
                foreach (string splitItem in splitItems)
                {
                    listBox.Items.Add(splitItem.Trim());
                }
            }
        }

        private void createInvoiceButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;

            db.Open();

            db.CreateProforma(invoiceSellerListbox, invoiceBuyerListbox, invoiceProductsListbox, textBox1.Text, random.Next(600000, 1000001), comboBox1.SelectedItem.ToString());

            db.Close();
        }

        private void excelButton_Click(object sender, EventArgs e)
        {
            db.ExportToExcel(comboBox2.SelectedItem.ToString());
        }
    }
}
