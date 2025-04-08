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
    public partial class SellerForm : Form
    {
        private Database db;
        private MainForm _mainForm;
        public SellerForm(MainForm mainForm)
        {
            InitializeComponent();

            db = new Database();
            _mainForm = mainForm;
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            db.Open();

            db.LoadCompaniesData(sellerListbox);
            db.LoadDataIntoComboBox("cities", "name", sellerCityComboBox);

            db.Close();
        }

        private void addSellerButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(sellerNameTextbox.Text) || sellerCityComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Name and city is required to add to database!");
                return;
            }

            db.Open();

            db.SaveBuyer(sellerNameTextbox.Text, sellerAddressTextbox.Text, sellerPhoneTextbox.Text, sellerCityComboBox.SelectedItem.ToString());
            db.LoadCompaniesData(sellerListbox);

            db.Close();
        }

        private void sellerListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sellerListbox.SelectedItem == null)
                return;

            if (_mainForm.sellerRichTextbox.Text == "" && !deleteCheckbox.Checked)
            {
                List<string> selectedItems = new List<string>();

                foreach (var item in sellerListbox.SelectedItems)
                {
                    selectedItems.Add(item.ToString());
                }

                string formattedText = sellerListbox.SelectedItem.ToString().Replace("|", "\n");
                _mainForm.sellerRichTextbox.Text = formattedText;
                this.Close();
            }
            else if(deleteCheckbox.Checked)
            {
                db.Open();
                db.DeleteFrom(sellerListbox, "companies", "name");
                db.Close();
            }
        }
    }
}
