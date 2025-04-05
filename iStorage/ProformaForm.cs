using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace iStorage
{
    public partial class ProformaForm : Form
    {
        public ProformaForm(string companyName, string buyerName, List<string> items, string expireDate, int invoiceNumber, string paymentType)
        {
            InitializeComponent();

            PopulateProforma(companyName, buyerName, items, expireDate, invoiceNumber, paymentType);
        }

        private void PopulateProforma(string companyName, string buyerName, List<string> items, string expireDate, int invoiceNumber, string paymentType)
        {
            StringBuilder proformaText = new StringBuilder();

            proformaText.AppendLine("PROFORMA INVOICE");
            proformaText.AppendLine("-----------------");
            proformaText.AppendLine($"Invoice Number: {invoiceNumber}");
            proformaText.AppendLine($"Company: {companyName}");
            proformaText.AppendLine($"Buyer: {buyerName}");
            proformaText.AppendLine($"Due date: {expireDate}");
            proformaText.AppendLine($"Payment Type: {paymentType}");
            proformaText.AppendLine("\nProducts:");
            proformaText.AppendLine("-----------------");

            foreach (var item in items)
            {
                proformaText.AppendLine(item);
            }

            proformaRichBox.Text = proformaText.ToString();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pdfButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Save PDF File";
            saveFileDialog.FileName = "Proforma.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Document pdfDoc = new Document(PageSize.A4);
                    PdfWriter.GetInstance(pdfDoc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    pdfDoc.Open();

                    string richText = proformaRichBox.Text;
                    Paragraph paragraph = new Paragraph(richText);
                    pdfDoc.Add(paragraph);

                    pdfDoc.Close();

                    MessageBox.Show("PDF exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exporting PDF:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ProformaForm_Load(object sender, EventArgs e)
        {

        }

        private void printButton_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.PrintPage += PrintDocument_PrintPage;

                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            string textToPrint = proformaRichBox.Text;

            System.Drawing.Font printFont = new System.Drawing.Font("Arial", 10);

            Brush printBrush = Brushes.Black;

            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            e.Graphics.DrawString(textToPrint, printFont, printBrush, x, y);
        }
    }
}
