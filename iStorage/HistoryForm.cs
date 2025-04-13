using com.itextpdf.text.pdf;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace iStorage
{
    public partial class HistoryForm : Form
    {
        private MainForm mainForm;
        private Database db;

        public HistoryForm()
        {
            InitializeComponent();

            mainForm = (MainForm)Application.OpenForms["MainForm"];
            db = new Database();
        }

        private void listBoxHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxHistory.SelectedIndex >= 0)
            {
                string selectedLine = listBoxHistory.SelectedItem.ToString();

                // Assuming invoice_number is the first field in the string:
                string invoiceNumber = selectedLine.Split('|')[4].Trim();

                db.Open();
                db.LoadProformaInvoiceData(mainForm.invoiceProductsListbox, mainForm.sellerRichTextbox, mainForm.buyerRichTextbox, invoiceNumber);
                db.Close();

                double total = 0;
                CultureInfo europeanCulture = new CultureInfo("sl-SI");

                foreach (var item in mainForm.invoiceProductsListbox.Items)
                {
                    string[] lines = item.ToString().Split('\n');
                    if (lines.Length >= 3)
                    {
                        string priceString = lines[2].Trim();

                        if (double.TryParse(priceString, NumberStyles.Any, europeanCulture, out double itemTotal))
                        {
                            total += itemTotal;
                        }
                    }
                }

                mainForm.totalInvoicePrice = total;
                mainForm.label6.Text = "Total: " + total.ToString("0.00", CultureInfo.InvariantCulture);

            }
        }



        private void HistoryForm_Load(object sender, EventArgs e)
        {
            db.Open();

            db.LoadData(listBoxHistory, "proforma_invoices");

            db.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.Open();

            db.LoadData(listBoxHistory, "proforma_invoices");

            db.Close();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            string inputInvoiceNumber = filterTextbox.Text;

            if (string.IsNullOrWhiteSpace(inputInvoiceNumber))
            {
                MessageBox.Show("Please enter a valid invoice number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Convert the ListBox items to a list and filter based on the invoice number
            var matchingItems = listBoxHistory.Items.Cast<string>()
                                                    .Where(item => item.Contains(inputInvoiceNumber))
                                                    .ToList();

            // Clear the ListBox and add the filtered items
            listBoxHistory.Items.Clear();
            foreach (var item in matchingItems)
            {
                listBoxHistory.Items.Add(item);
            }

            // If no matching items, display a message
            if (matchingItems.Count == 0)
            {
                listBoxHistory.Items.Add("No matching items found.");
            }
        }

    }
}
