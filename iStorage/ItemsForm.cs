using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using iTextSharp.text.pdf.parser.clipper;

namespace iStorage
{
    public partial class ItemsForm : Form
    {
        private Database db;
        private MainForm _mainForm;

        public ItemsForm(MainForm mainForm)
        {
            InitializeComponent();

            try
            {
                db = new Database();
                _mainForm = mainForm;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing form: " + ex.Message);
            }
        }

        private void ItemsForm_Load(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                db.Open();
                db.LoadItemsData(itemListbox);
                db.LoadDataIntoComboBox("images", "description", imageCombobox);
                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading form data: " + ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void addItemDatabaseButton_Click(object sender, EventArgs e)
        {
            try
            {
                db.Open();

                if (imageCombobox.SelectedItem == null)
                {
                    if (productNameTextbox.Text == "")
                        MessageBox.Show("Name is not specified!");
                    else
                        db.SaveItemWithoutImage(productNameTextbox.Text, Convert.ToDouble(priceTextbox.Text, CultureInfo.InvariantCulture), productDescriptionTextbox.Text);
                }
                else
                {
                    db.SaveItem(productNameTextbox.Text, Convert.ToDouble(priceTextbox.Text, CultureInfo.InvariantCulture), productDescriptionTextbox.Text, imageCombobox.SelectedItem.ToString());
                }

                db.LoadItemsData(itemListbox);
                db.Close();
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Invalid price format: " + fe.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding item to database: " + ex.Message);
            }
        }

        private void addItemInvoiceButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (itemListbox.SelectedItem is Item selected)
                {
                    int quantity = (int)amountNumericUpDown.Value;
                    double total = selected.Price * quantity;

                    InvoiceItem invoiceItem = new InvoiceItem
                    {
                        ItemName = selected.ItemName,
                        ItemDescription = selected.ItemDescription,
                        Quantity = quantity,
                        TotalPrice = total
                    };

                    _mainForm.invoiceProductsListbox.Items.Add(invoiceItem);

                    _mainForm.totalInvoicePrice += total;
                    _mainForm.label6.Text = "Total: " + _mainForm.totalInvoicePrice.ToString("0.00", CultureInfo.InvariantCulture);

                    amountNumericUpDown.Value = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding item to invoice: " + ex.Message);
            }
        }

        private void itemListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (itemListbox.SelectedItem == null)
                    return;

                if (itemListbox.SelectedItem is Item selectedItem)
                {
                    string itemName = selectedItem.ItemName;

                    db.Open();

                    int? imageId = selectedItem.ImageID;

                    if (imageId == null || imageId == 0)
                    {
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        string imageUrl = db.GetImageUrl(imageId.Value);

                        if (!string.IsNullOrEmpty(imageUrl))
                        {
                            pictureBox1.Load(imageUrl);
                        }
                        else
                        {
                            pictureBox1.Image = null;
                        }
                    }

                    db.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }

        private void amountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (itemListbox.SelectedItem == null)
                    return;

                db.Open();
                db.DeleteFrom(itemListbox, "items", "name");
                db.LoadItemsData(itemListbox);
                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting item: " + ex.Message);
            }
        }
    }
}
