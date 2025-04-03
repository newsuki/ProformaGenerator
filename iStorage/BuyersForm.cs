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
        public BuyersForm()
        {
            InitializeComponent();

            db = new Database();
        }

        private void BuyersForm_Load(object sender, EventArgs e)
        {
            db.Open();

            db.LoadDataIntoComboBox("cities", "name", cityComboBox);
            db.LoadData(buyerListbox, "buyers");

            db.Close();
        }

        private void addBuyerButton_Click(object sender, EventArgs e)
        {
            db.Open();

            db.SaveBuyer(firstNameTextbox.Text, lastNameTextbox.Text, addressTextbox.Text, phoneTextbox.Text, cityComboBox.SelectedItem.ToString());
            db.LoadData(buyerListbox, "buyers");

            db.Close();
        }

        private void buyerListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (buyerListbox.SelectedItem == null)
                return;

            this.Close();
        }
    }
}
