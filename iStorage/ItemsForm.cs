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

namespace iStorage
{
    public partial class ItemsForm : Form
    {
        private Database db;
        private MainForm _mainForm;
        public ItemsForm(MainForm mainForm)
        {
            InitializeComponent();

            db = new Database();
            _mainForm = mainForm;
        }

        private void ItemsForm_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            db.Open();

            db.LoadItemsData(itemListbox);
            db.LoadDataIntoComboBox("images", "description", imageCombobox);

            db.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void addItemDatabaseButton_Click(object sender, EventArgs e)
        {
            db.Open();

            db.SaveItem(productNameTextbox.Text, Convert.ToDouble(priceTextbox.Text, CultureInfo.InvariantCulture), Convert.ToInt32(stockNumericUpDown.Value), productDescriptionTextbox.Text, imageCombobox.SelectedItem.ToString());
            db.LoadItemsData(itemListbox);

            db.Close();
        }

        private void addItemInvoiceButton_Click(object sender, EventArgs e)
        {
            amountNumericUpDown.Value = 1;

            List<string> selectedItems = new List<string>();

            foreach (var item in itemListbox.SelectedItems)
            {
                selectedItems.Add(item.ToString());
            }

            _mainForm.AddSelectedItemsToListBox(selectedItems, _mainForm.invoiceProductsListbox);
        }

        private void itemListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemListbox.SelectedItem == null)
                return;

            amountNumericUpDown.Value = 1;

            string selectedItem = itemListbox.SelectedItem.ToString();
            string[] itemParts = selectedItem.Split('|');
            if (itemParts.Length < 2)
                return;

            string itemName = itemParts[0].Trim(); 

            db.Open();

            int? imageId = db.GetImageIdByName(itemName);
            if (imageId == null)
            {
                db.Close();
                return;
            }

            string imageUrl = db.GetImageUrl(imageId.Value);

            db.Close();

            if (!string.IsNullOrEmpty(imageUrl))
            {
                pictureBox1.Load(imageUrl);
            }
        }

        private void amountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            if (itemListbox.SelectedItem == null)
                return;

            db.Open();

            db.DeleteFrom(itemListbox, "items", "name");

            db.Close();
        }
    }
}
