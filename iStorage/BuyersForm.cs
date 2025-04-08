using DocumentFormat.OpenXml;
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
    public partial class BuyersForm : Form
    {
        private Database db;
        private MainForm _mainForm;
        public BuyersForm(MainForm mainForm)
        {
            InitializeComponent();

            db = new Database();
            _mainForm = mainForm;
        }

        private void BuyersForm_Load(object sender, EventArgs e)
        {
            db.Open();

            db.LoadDataIntoComboBox("cities", "name", cityComboBox);
            db.LoadBuyersData(buyerListbox);

            db.Close();
        }

        private void addBuyerButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNameTextbox.Text) || cityComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Name and city is required to add to database!");
                return;
            }

            db.Open();

            db.SaveBuyer(firstNameTextbox.Text, addressTextbox.Text, phoneTextbox.Text, cityComboBox.SelectedItem.ToString());

            db.LoadBuyersData(buyerListbox);

            db.Close();
        }

        private void buyerListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (buyerListbox.SelectedItem == null)
                return;

            if (_mainForm.buyerRichTextbox.Text == "" && !deleteCheckbox.Checked)
            {
                List<string> selectedItems = new List<string>();

                foreach (var item in buyerListbox.SelectedItems)
                {
                    selectedItems.Add(item.ToString());
                }

                string formattedText = buyerListbox.SelectedItem.ToString().Replace("|", "\n");
                _mainForm.buyerRichTextbox.Text = formattedText;
                this.Close();
            }
            else if (deleteCheckbox.Checked)
            {
                db.Open();
                db.DeleteFrom(buyerListbox, "buyers", "name");
                db.Close();
            }
        }

        private void deleteCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
