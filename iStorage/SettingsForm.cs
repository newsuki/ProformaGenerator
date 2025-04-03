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
    public partial class SettingsForm : Form
    {
        private Database db;
        private string selectedTable;
        private string column;
        public SettingsForm()
        {
            InitializeComponent();

            db = new Database();
        }

        private void countryNameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void settingsForm_Load(object sender, EventArgs e)
        {
            db.Open();

            db.LoadDataIntoComboBox("countries", "name", countryOriginComboBox);

            db.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void descriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void addImageButton_Click(object sender, EventArgs e)
        {
            if (imageUrlTextbox.Text == "")
                MessageBox.Show("Invalid or missing URL!");
            else
            {
                db.Open();

                db.SaveImage(imageUrlTextbox.Text, imageDescriptionTextbox.Text);
                MessageBox.Show("Added an image to the database!");

                db.Close();
            }
        }

        private void imageUrlTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void imagesLabel_Click(object sender, EventArgs e)
        {

        }

        private void addCountryButton_Click(object sender, EventArgs e)
        {
            if (countryNameTextbox.Text == "" || countryCodeTextbox.Text == "")
                MessageBox.Show("The name or code is either missing or invalid!");
            else
            {
                db.Open();

                db.SaveCountry(countryNameTextbox.Text, countryCodeTextbox.Text);
                MessageBox.Show("Added a country to the database!");

                db.Close();
            }
        }

        private void displaySettingsInfoListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedTable == "" || column == "")
                return;

            if (displaySettingsInfoListbox.SelectedItem == null)
                return;

            db.Open();

            db.DeleteFrom(displaySettingsInfoListbox, selectedTable, column);

            db.Close();
        }

        private void displayCountriesButton_Click(object sender, EventArgs e)
        {
            db.Open();

            db.LoadData(displaySettingsInfoListbox, "countries");
            selectedTable = "countries";
            column = "name";

            db.Close();
        }

        private void displayCitiesButton_Click(object sender, EventArgs e)
        {
            db.Open();

            db.LoadData(displaySettingsInfoListbox, "cities");
            selectedTable = "cities";
            column = "name";

            db.Close();
        }

        private void addCityButton_Click(object sender, EventArgs e)
        {
            if (cityNameTextbox.Text == "" || postalTextbox.Text == "" || countryOriginComboBox.SelectedItem == null)
                MessageBox.Show("The name or code is either missing or invalid!");
            else
            {
                db.Open();

                db.SaveCity(cityNameTextbox.Text, postalTextbox.Text, countryOriginComboBox.SelectedItem.ToString());
                MessageBox.Show("Added a city to the database!");

                db.Close();
            }
        }

        private void displayImagesButton_Click(object sender, EventArgs e)
        {
            db.Open();

            db.LoadData(displaySettingsInfoListbox, "images");
            selectedTable = "images";
            column = "url";

            db.Close();
        }
    }
}
