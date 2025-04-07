using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
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
        public ProformaForm(string companyName, string buyerName, List<string> items, string expireDate, int invoiceNumber, double total)
        {
            InitializeComponent();

            PopulateProforma(companyName, buyerName, items, expireDate, invoiceNumber, total);
        }

        private void PopulateProforma(string companyName, string buyerName, List<string> items, string expireDate, int invoiceNumber, double total)
        {
            proformaRichBox.Clear();
            proformaRichBox.Font = new System.Drawing.Font("Segoe UI", 10);

            void AppendLine(string text, FontStyle style, Color color, int size = 10)
            {
                proformaRichBox.SelectionStart = proformaRichBox.TextLength;
                proformaRichBox.SelectionLength = 0;

                proformaRichBox.SelectionColor = color;
                proformaRichBox.SelectionFont = new System.Drawing.Font("Segoe UI", size, style);
                proformaRichBox.AppendText(text + Environment.NewLine);
                proformaRichBox.SelectionColor = proformaRichBox.ForeColor;
            }

            // Header
            AppendLine("PROFORMA INVOICE", FontStyle.Bold, Color.DarkBlue, 14);
            AppendLine("____________________________", FontStyle.Regular, Color.Gray);

            // Details
            AppendLine($"Invoice Number: {invoiceNumber}", FontStyle.Bold, Color.Black);
            AppendLine($"Company: {companyName}", FontStyle.Regular, Color.Black);
            AppendLine($"Buyer: {buyerName}", FontStyle.Regular, Color.Black);
            AppendLine($"Due date: {expireDate}", FontStyle.Regular, Color.Black);
            AppendLine($"TOTAL: {total.ToString("0.00", CultureInfo.InvariantCulture)}", FontStyle.Bold, Color.DarkRed);

            AppendLine("\nProducts:", FontStyle.Bold, Color.DarkGreen, 12);
            AppendLine("____________________________", FontStyle.Regular, Color.Gray);

            foreach (var item in items)
            {
                AppendLine($"• {item}", FontStyle.Regular, Color.Black);
            }
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
