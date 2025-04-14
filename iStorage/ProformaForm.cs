using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace iStorage
{
    public partial class ProformaForm : Form
    {
        public ProformaForm(string companyName, string buyerName, List<InvoiceItem> items, string expireDate, string invoiceNumber, double total)
        {
            InitializeComponent();
            PopulateProforma(companyName, buyerName, items, expireDate, invoiceNumber, total);
        }


        private void PopulateProforma(string companyName, string buyerName, List<InvoiceItem> items, string expireDate, string invoiceNumber, double total)
        {
            proformaRichBox.Clear();
            proformaRichBox.Font = new System.Drawing.Font("Consolas", 10);

            void AppendLine(string text = "", FontStyle style = FontStyle.Regular, Color? color = null, int size = 10)
            {
                proformaRichBox.SelectionStart = proformaRichBox.TextLength;
                proformaRichBox.SelectionLength = 0;

                proformaRichBox.SelectionColor = color ?? Color.Black;
                proformaRichBox.SelectionFont = new System.Drawing.Font("Consolas", size, style);
                proformaRichBox.AppendText(text + Environment.NewLine);
                proformaRichBox.SelectionColor = proformaRichBox.ForeColor;
            }

            AppendLine("PROFORMA INVOICE", FontStyle.Bold, Color.Black, 16);
            AppendLine();
            AppendLine($"{companyName}", FontStyle.Bold, Color.Gray, 10);
            AppendLine();

            AppendLine("Invoice No. :".PadRight(15) + $"{invoiceNumber}", FontStyle.Regular);
            AppendLine("Issue Date  :".PadRight(15) + $"{DateTime.Today:dd/MM/yyyy}", FontStyle.Regular);
            AppendLine("Due Date    :".PadRight(15) + $"{expireDate}", FontStyle.Regular);
            AppendLine();

            AppendLine("BILL TO:", FontStyle.Bold, Color.Black);
            AppendLine(buyerName, FontStyle.Regular);
            AppendLine();

            AppendLine("PRODUCT".PadRight(25) + "QTY".PadLeft(5) + "x" + "UNIT (€)".PadLeft(10) + "TOTAL (€)".PadLeft(10),
                       FontStyle.Bold, Color.Black);


            foreach (var item in items)
            {
                double unitPrice = item.Quantity > 0 ? item.TotalPrice / item.Quantity : 0;

                AppendLine(
                    item.ItemName.PadRight(25) +
                    item.Quantity.ToString().PadLeft(5) + "x" +
                    unitPrice.ToString("0.00").PadLeft(10) + "€" +
                    item.TotalPrice.ToString("0.00").PadLeft(10) + "€",
                    FontStyle.Regular, Color.Black
                );



                if (!string.IsNullOrWhiteSpace(item.ItemDescription))
                    AppendLine("  " + item.ItemDescription, FontStyle.Italic, Color.DimGray, 9);

                AppendLine();
            }

            AppendLine(new string('-', 70), FontStyle.Regular, Color.Gray);
            AppendLine("".PadRight(52) + "TOTAL (EUR):".PadLeft(14) + total.ToString("0.00").PadLeft(14),
                       FontStyle.Bold, Color.DarkRed, 11);
            AppendLine("".PadRight(52) + "TOTAL DUE (EUR):".PadLeft(14) + total.ToString("0.00").PadLeft(14),
                       FontStyle.Bold, Color.White, 11);

            AppendLine();
            AppendLine("Issued by:", FontStyle.Regular, Color.Black);
            AppendLine(companyName, FontStyle.Bold, Color.Black);
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
                    using (var stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4);
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        BaseFont helveticaBaseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

                        iTextSharp.text.Font regularFont = new iTextSharp.text.Font(helveticaBaseFont, 10f, iTextSharp.text.Font.NORMAL);
                        iTextSharp.text.Font boldFont = new iTextSharp.text.Font(helveticaBaseFont, 10f, iTextSharp.text.Font.BOLD);
                        iTextSharp.text.Font italicFont = new iTextSharp.text.Font(helveticaBaseFont, 9f, iTextSharp.text.Font.ITALIC);
                        iTextSharp.text.Font redFont = new iTextSharp.text.Font(helveticaBaseFont, 10f, iTextSharp.text.Font.BOLD, BaseColor.RED);
                        iTextSharp.text.Font grayFont = new iTextSharp.text.Font(helveticaBaseFont, 10f, iTextSharp.text.Font.NORMAL, new BaseColor(169, 169, 169)); // Gray

                        foreach (var line in proformaRichBox.Lines)
                        {
                            string trimmedLine = line.Trim();

                            if (trimmedLine.Contains("PROFORMA INVOICE"))
                            {
                                Paragraph title = new Paragraph(trimmedLine, new iTextSharp.text.Font(helveticaBaseFont, 16f, iTextSharp.text.Font.BOLD))
                                {
                                    Alignment = Element.ALIGN_CENTER
                                };
                                pdfDoc.Add(title);
                                pdfDoc.Add(new Paragraph("\n")); // Space after title
                            }
                            else if (trimmedLine.Contains("BILL TO:"))
                            {
                                Paragraph billTo = new Paragraph(trimmedLine, boldFont);
                                pdfDoc.Add(billTo);
                            }
                            else if (trimmedLine.StartsWith("TOTAL (EUR):"))
                            {
                                Paragraph totalAmount = new Paragraph(trimmedLine, redFont)
                                {
                                    Alignment = Element.ALIGN_RIGHT
                                };
                                pdfDoc.Add(new Paragraph("\n")); // Spacer before total
                                pdfDoc.Add(totalAmount);
                            }
                            else if (trimmedLine.StartsWith("PRODUCT")) // Header for items
                            {
                                PdfPTable table = new PdfPTable(4);
                                table.WidthPercentage = 100;
                                table.SetWidths(new float[] { 45f, 15f, 20f, 20f });

                                AddCell(table, "PRODUCT", boldFont);
                                AddCell(table, "QTY", boldFont);
                                AddCell(table, "UNIT (€)", boldFont);
                                AddCell(table, "TOTAL (€)", boldFont);

                                pdfDoc.Add(new Paragraph("\n")); // Space before table
                                pdfDoc.Add(table);
                            }
                            else if (trimmedLine.Contains("x") && trimmedLine.Contains("€")) // Item rows
                            {
                                // Example: Mouse              2x     25.00€    50.00€
                                string[] parts = Regex.Split(trimmedLine, @"\s{2,}"); // Split by 2+ spaces

                                if (parts.Length >= 4)
                                {
                                    PdfPTable row = new PdfPTable(4);
                                    row.WidthPercentage = 100;
                                    row.SetWidths(new float[] { 45f, 15f, 20f, 20f });

                                    foreach (string part in parts)
                                    {
                                        AddCell(row, part.Trim(), regularFont);
                                    }

                                    pdfDoc.Add(row);
                                }
                                else
                                {
                                    pdfDoc.Add(new Paragraph(trimmedLine, regularFont)); // fallback
                                }
                            }
                            else
                            {
                                // Spacer after BILL TO block
                                if (trimmedLine == "") pdfDoc.Add(new Paragraph("\n"));

                                Paragraph regularText = new Paragraph(trimmedLine, regularFont);
                                pdfDoc.Add(regularText);
                            }
                        }


                        pdfDoc.Close();
                    }

                    MessageBox.Show("PDF exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exporting PDF:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddCell(PdfPTable table, string text, iTextSharp.text.Font font)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text, font));
            cell.Border = iTextSharp.text.Rectangle.NO_BORDER;
            cell.HorizontalAlignment = Element.ALIGN_LEFT;
            table.AddCell(cell);
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
