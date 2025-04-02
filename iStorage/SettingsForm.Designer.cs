namespace iStorage
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.countryNameTextbox = new System.Windows.Forms.TextBox();
            this.countryCodeTextbox = new System.Windows.Forms.TextBox();
            this.countrySettingsLabel = new System.Windows.Forms.Label();
            this.countryNameLabel = new System.Windows.Forms.Label();
            this.countryCodeLabel = new System.Windows.Forms.Label();
            this.addCountryButton = new System.Windows.Forms.Button();
            this.citiesLabel = new System.Windows.Forms.Label();
            this.addCityButton = new System.Windows.Forms.Button();
            this.postalLabel = new System.Windows.Forms.Label();
            this.cityNameLabel = new System.Windows.Forms.Label();
            this.postalTextbox = new System.Windows.Forms.TextBox();
            this.cityNameTextbox = new System.Windows.Forms.TextBox();
            this.addImageButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.urlLabel = new System.Windows.Forms.Label();
            this.imageDescriptionTextbox = new System.Windows.Forms.TextBox();
            this.imageUrlTextbox = new System.Windows.Forms.TextBox();
            this.imagesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.displaySettingsInfoListbox = new System.Windows.Forms.ListBox();
            this.displayCountriesButton = new System.Windows.Forms.Button();
            this.displayCitiesButton = new System.Windows.Forms.Button();
            this.displayImagesButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.countryOriginComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // countryNameTextbox
            // 
            this.countryNameTextbox.Location = new System.Drawing.Point(9, 152);
            this.countryNameTextbox.Name = "countryNameTextbox";
            this.countryNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.countryNameTextbox.TabIndex = 0;
            this.countryNameTextbox.TextChanged += new System.EventHandler(this.countryNameTextbox_TextChanged);
            // 
            // countryCodeTextbox
            // 
            this.countryCodeTextbox.Location = new System.Drawing.Point(9, 190);
            this.countryCodeTextbox.Name = "countryCodeTextbox";
            this.countryCodeTextbox.Size = new System.Drawing.Size(100, 20);
            this.countryCodeTextbox.TabIndex = 1;
            // 
            // countrySettingsLabel
            // 
            this.countrySettingsLabel.AutoSize = true;
            this.countrySettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.countrySettingsLabel.Location = new System.Drawing.Point(4, 100);
            this.countrySettingsLabel.Name = "countrySettingsLabel";
            this.countrySettingsLabel.Size = new System.Drawing.Size(104, 25);
            this.countrySettingsLabel.TabIndex = 2;
            this.countrySettingsLabel.Text = "Countries";
            // 
            // countryNameLabel
            // 
            this.countryNameLabel.AutoSize = true;
            this.countryNameLabel.Location = new System.Drawing.Point(6, 136);
            this.countryNameLabel.Name = "countryNameLabel";
            this.countryNameLabel.Size = new System.Drawing.Size(72, 13);
            this.countryNameLabel.TabIndex = 3;
            this.countryNameLabel.Text = "Country name";
            // 
            // countryCodeLabel
            // 
            this.countryCodeLabel.AutoSize = true;
            this.countryCodeLabel.Location = new System.Drawing.Point(6, 174);
            this.countryCodeLabel.Name = "countryCodeLabel";
            this.countryCodeLabel.Size = new System.Drawing.Size(111, 13);
            this.countryCodeLabel.TabIndex = 4;
            this.countryCodeLabel.Text = "Country code (3-letter)";
            // 
            // addCountryButton
            // 
            this.addCountryButton.Location = new System.Drawing.Point(9, 216);
            this.addCountryButton.Name = "addCountryButton";
            this.addCountryButton.Size = new System.Drawing.Size(99, 23);
            this.addCountryButton.TabIndex = 5;
            this.addCountryButton.Text = "Add country";
            this.addCountryButton.UseVisualStyleBackColor = true;
            this.addCountryButton.Click += new System.EventHandler(this.addCountryButton_Click);
            // 
            // citiesLabel
            // 
            this.citiesLabel.AutoSize = true;
            this.citiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.citiesLabel.Location = new System.Drawing.Point(4, 242);
            this.citiesLabel.Name = "citiesLabel";
            this.citiesLabel.Size = new System.Drawing.Size(66, 25);
            this.citiesLabel.TabIndex = 6;
            this.citiesLabel.Text = "Cities";
            // 
            // addCityButton
            // 
            this.addCityButton.Location = new System.Drawing.Point(8, 395);
            this.addCityButton.Name = "addCityButton";
            this.addCityButton.Size = new System.Drawing.Size(100, 23);
            this.addCityButton.TabIndex = 11;
            this.addCityButton.Text = "Add city";
            this.addCityButton.UseVisualStyleBackColor = true;
            this.addCityButton.Click += new System.EventHandler(this.addCityButton_Click);
            // 
            // postalLabel
            // 
            this.postalLabel.AutoSize = true;
            this.postalLabel.Location = new System.Drawing.Point(6, 313);
            this.postalLabel.Name = "postalLabel";
            this.postalLabel.Size = new System.Drawing.Size(74, 13);
            this.postalLabel.TabIndex = 10;
            this.postalLabel.Text = "Postal number";
            // 
            // cityNameLabel
            // 
            this.cityNameLabel.AutoSize = true;
            this.cityNameLabel.Location = new System.Drawing.Point(6, 275);
            this.cityNameLabel.Name = "cityNameLabel";
            this.cityNameLabel.Size = new System.Drawing.Size(53, 13);
            this.cityNameLabel.TabIndex = 9;
            this.cityNameLabel.Text = "City name";
            // 
            // postalTextbox
            // 
            this.postalTextbox.Location = new System.Drawing.Point(9, 329);
            this.postalTextbox.Name = "postalTextbox";
            this.postalTextbox.Size = new System.Drawing.Size(100, 20);
            this.postalTextbox.TabIndex = 8;
            // 
            // cityNameTextbox
            // 
            this.cityNameTextbox.Location = new System.Drawing.Point(9, 291);
            this.cityNameTextbox.Name = "cityNameTextbox";
            this.cityNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.cityNameTextbox.TabIndex = 7;
            // 
            // addImageButton
            // 
            this.addImageButton.Location = new System.Drawing.Point(129, 216);
            this.addImageButton.Name = "addImageButton";
            this.addImageButton.Size = new System.Drawing.Size(100, 23);
            this.addImageButton.TabIndex = 26;
            this.addImageButton.Text = "Add image";
            this.addImageButton.UseVisualStyleBackColor = true;
            this.addImageButton.Click += new System.EventHandler(this.addImageButton_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(126, 174);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(93, 13);
            this.descriptionLabel.TabIndex = 25;
            this.descriptionLabel.Text = "Description/Name";
            this.descriptionLabel.Click += new System.EventHandler(this.descriptionLabel_Click);
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(126, 136);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(29, 13);
            this.urlLabel.TabIndex = 24;
            this.urlLabel.Text = "URL";
            this.urlLabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // imageDescriptionTextbox
            // 
            this.imageDescriptionTextbox.Location = new System.Drawing.Point(129, 190);
            this.imageDescriptionTextbox.Name = "imageDescriptionTextbox";
            this.imageDescriptionTextbox.Size = new System.Drawing.Size(235, 20);
            this.imageDescriptionTextbox.TabIndex = 23;
            this.imageDescriptionTextbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // imageUrlTextbox
            // 
            this.imageUrlTextbox.Location = new System.Drawing.Point(129, 152);
            this.imageUrlTextbox.Name = "imageUrlTextbox";
            this.imageUrlTextbox.Size = new System.Drawing.Size(235, 20);
            this.imageUrlTextbox.TabIndex = 22;
            this.imageUrlTextbox.TextChanged += new System.EventHandler(this.imageUrlTextbox_TextChanged);
            // 
            // imagesLabel
            // 
            this.imagesLabel.AutoSize = true;
            this.imagesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imagesLabel.Location = new System.Drawing.Point(124, 100);
            this.imagesLabel.Name = "imagesLabel";
            this.imagesLabel.Size = new System.Drawing.Size(81, 25);
            this.imagesLabel.TabIndex = 21;
            this.imagesLabel.Text = "Images";
            this.imagesLabel.Click += new System.EventHandler(this.imagesLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(2, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 39);
            this.label1.TabIndex = 27;
            this.label1.Text = "Settings";
            // 
            // displaySettingsInfoListbox
            // 
            this.displaySettingsInfoListbox.FormattingEnabled = true;
            this.displaySettingsInfoListbox.Location = new System.Drawing.Point(373, 47);
            this.displaySettingsInfoListbox.Name = "displaySettingsInfoListbox";
            this.displaySettingsInfoListbox.Size = new System.Drawing.Size(469, 381);
            this.displaySettingsInfoListbox.TabIndex = 28;
            this.displaySettingsInfoListbox.SelectedIndexChanged += new System.EventHandler(this.displaySettingsInfoListbox_SelectedIndexChanged);
            // 
            // displayCountriesButton
            // 
            this.displayCountriesButton.Location = new System.Drawing.Point(147, 299);
            this.displayCountriesButton.Name = "displayCountriesButton";
            this.displayCountriesButton.Size = new System.Drawing.Size(62, 90);
            this.displayCountriesButton.TabIndex = 29;
            this.displayCountriesButton.Text = "Display countries";
            this.displayCountriesButton.UseVisualStyleBackColor = true;
            this.displayCountriesButton.Click += new System.EventHandler(this.displayCountriesButton_Click);
            // 
            // displayCitiesButton
            // 
            this.displayCitiesButton.Location = new System.Drawing.Point(215, 299);
            this.displayCitiesButton.Name = "displayCitiesButton";
            this.displayCitiesButton.Size = new System.Drawing.Size(62, 90);
            this.displayCitiesButton.TabIndex = 30;
            this.displayCitiesButton.Text = "Display cities";
            this.displayCitiesButton.UseVisualStyleBackColor = true;
            this.displayCitiesButton.Click += new System.EventHandler(this.displayCitiesButton_Click);
            // 
            // displayImagesButton
            // 
            this.displayImagesButton.Location = new System.Drawing.Point(283, 299);
            this.displayImagesButton.Name = "displayImagesButton";
            this.displayImagesButton.Size = new System.Drawing.Size(62, 90);
            this.displayImagesButton.TabIndex = 31;
            this.displayImagesButton.Text = "Display images";
            this.displayImagesButton.UseVisualStyleBackColor = true;
            this.displayImagesButton.Click += new System.EventHandler(this.displayImagesButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(370, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Click to remove";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Country of origin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(710, 31);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Adrian Karahmetović 2025";
            // 
            // countryOriginComboBox
            // 
            this.countryOriginComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryOriginComboBox.FormattingEnabled = true;
            this.countryOriginComboBox.Location = new System.Drawing.Point(8, 368);
            this.countryOriginComboBox.Name = "countryOriginComboBox";
            this.countryOriginComboBox.Size = new System.Drawing.Size(121, 21);
            this.countryOriginComboBox.TabIndex = 36;
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 440);
            this.Controls.Add(this.countryOriginComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.displayImagesButton);
            this.Controls.Add(this.displayCitiesButton);
            this.Controls.Add(this.displayCountriesButton);
            this.Controls.Add(this.displaySettingsInfoListbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addImageButton);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.imageDescriptionTextbox);
            this.Controls.Add(this.imageUrlTextbox);
            this.Controls.Add(this.imagesLabel);
            this.Controls.Add(this.addCityButton);
            this.Controls.Add(this.postalLabel);
            this.Controls.Add(this.cityNameLabel);
            this.Controls.Add(this.postalTextbox);
            this.Controls.Add(this.cityNameTextbox);
            this.Controls.Add(this.citiesLabel);
            this.Controls.Add(this.addCountryButton);
            this.Controls.Add(this.countryCodeLabel);
            this.Controls.Add(this.countryNameLabel);
            this.Controls.Add(this.countrySettingsLabel);
            this.Controls.Add(this.countryCodeTextbox);
            this.Controls.Add(this.countryNameTextbox);
            this.Name = "settingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.settingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox countryNameTextbox;
        private System.Windows.Forms.TextBox countryCodeTextbox;
        private System.Windows.Forms.Label countrySettingsLabel;
        private System.Windows.Forms.Label countryNameLabel;
        private System.Windows.Forms.Label countryCodeLabel;
        private System.Windows.Forms.Button addCountryButton;
        private System.Windows.Forms.Label citiesLabel;
        private System.Windows.Forms.Button addCityButton;
        private System.Windows.Forms.Label postalLabel;
        private System.Windows.Forms.Label cityNameLabel;
        private System.Windows.Forms.TextBox postalTextbox;
        private System.Windows.Forms.TextBox cityNameTextbox;
        private System.Windows.Forms.Button addImageButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.TextBox imageDescriptionTextbox;
        private System.Windows.Forms.TextBox imageUrlTextbox;
        private System.Windows.Forms.Label imagesLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox displaySettingsInfoListbox;
        private System.Windows.Forms.Button displayCountriesButton;
        private System.Windows.Forms.Button displayCitiesButton;
        private System.Windows.Forms.Button displayImagesButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox countryOriginComboBox;
    }
}