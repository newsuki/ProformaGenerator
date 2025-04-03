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
        public SellerForm()
        {
            InitializeComponent();

            db = new Database();
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            db.Open();

            db.LoadData(sellerListbox, "companies");
            db.LoadDataIntoComboBox("cities", "name", sellerCityComboBox);

            db.Close();
        }

        private void addSellerButton_Click(object sender, EventArgs e)
        {
            db.Open();

            db.SaveSeller(sellerNameTextbox.Text, sellerAddressTextbox.Text, sellerPhoneTextbox.Text, sellerCityComboBox.SelectedItem.ToString());
            db.LoadData(sellerListbox, "companies");

            db.Close();
        }

        private void sellerListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sellerListbox.SelectedItem == null)
                return;

            this.Close();
        }
    }
}
