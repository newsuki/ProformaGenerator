namespace iStorage
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.appNameLabel = new System.Windows.Forms.Label();
            this.createInvoiceButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.invoiceProductsListbox = new System.Windows.Forms.ListBox();
            this.invoiceBuyerListbox = new System.Windows.Forms.ListBox();
            this.invoiceSellerListbox = new System.Windows.Forms.ListBox();
            this.selectCompanyButton = new System.Windows.Forms.Button();
            this.companySettingsPicture = new System.Windows.Forms.PictureBox();
            this.companyPicture = new System.Windows.Forms.PictureBox();
            this.clearInvoiceListboxes = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.excelButton = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.companySettingsPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Yu Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.appNameLabel.Location = new System.Drawing.Point(12, 27);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(429, 45);
            this.appNameLabel.TabIndex = 0;
            this.appNameLabel.Text = "Proforma Invoice Maker";
            this.appNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // createInvoiceButton
            // 
            this.createInvoiceButton.Location = new System.Drawing.Point(369, 359);
            this.createInvoiceButton.Name = "createInvoiceButton";
            this.createInvoiceButton.Size = new System.Drawing.Size(131, 49);
            this.createInvoiceButton.TabIndex = 3;
            this.createInvoiceButton.Text = "Create proforma invoice";
            this.createInvoiceButton.UseVisualStyleBackColor = true;
            this.createInvoiceButton.Click += new System.EventHandler(this.createInvoiceButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Select products";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 25);
            this.button2.TabIndex = 5;
            this.button2.Text = "Select buyer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // invoiceProductsListbox
            // 
            this.invoiceProductsListbox.FormattingEnabled = true;
            this.invoiceProductsListbox.Location = new System.Drawing.Point(153, 83);
            this.invoiceProductsListbox.Name = "invoiceProductsListbox";
            this.invoiceProductsListbox.ScrollAlwaysVisible = true;
            this.invoiceProductsListbox.Size = new System.Drawing.Size(162, 355);
            this.invoiceProductsListbox.TabIndex = 9;
            // 
            // invoiceBuyerListbox
            // 
            this.invoiceBuyerListbox.FormattingEnabled = true;
            this.invoiceBuyerListbox.Location = new System.Drawing.Point(321, 83);
            this.invoiceBuyerListbox.Name = "invoiceBuyerListbox";
            this.invoiceBuyerListbox.Size = new System.Drawing.Size(245, 121);
            this.invoiceBuyerListbox.TabIndex = 11;
            // 
            // invoiceSellerListbox
            // 
            this.invoiceSellerListbox.FormattingEnabled = true;
            this.invoiceSellerListbox.Location = new System.Drawing.Point(321, 210);
            this.invoiceSellerListbox.Name = "invoiceSellerListbox";
            this.invoiceSellerListbox.Size = new System.Drawing.Size(245, 121);
            this.invoiceSellerListbox.TabIndex = 12;
            this.invoiceSellerListbox.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // selectCompanyButton
            // 
            this.selectCompanyButton.Location = new System.Drawing.Point(16, 114);
            this.selectCompanyButton.Name = "selectCompanyButton";
            this.selectCompanyButton.Size = new System.Drawing.Size(131, 25);
            this.selectCompanyButton.TabIndex = 14;
            this.selectCompanyButton.Text = "Select seller";
            this.selectCompanyButton.UseVisualStyleBackColor = true;
            this.selectCompanyButton.Click += new System.EventHandler(this.selectCompanyButton_Click);
            // 
            // companySettingsPicture
            // 
            this.companySettingsPicture.Image = global::iStorage.Resource1._2821378;
            this.companySettingsPicture.Location = new System.Drawing.Point(506, 12);
            this.companySettingsPicture.Name = "companySettingsPicture";
            this.companySettingsPicture.Size = new System.Drawing.Size(60, 60);
            this.companySettingsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.companySettingsPicture.TabIndex = 8;
            this.companySettingsPicture.TabStop = false;
            this.companySettingsPicture.Click += new System.EventHandler(this.companySettingsPicture_Click);
            // 
            // companyPicture
            // 
            this.companyPicture.Image = ((System.Drawing.Image)(resources.GetObject("companyPicture.Image")));
            this.companyPicture.Location = new System.Drawing.Point(440, 12);
            this.companyPicture.Name = "companyPicture";
            this.companyPicture.Size = new System.Drawing.Size(60, 60);
            this.companyPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.companyPicture.TabIndex = 7;
            this.companyPicture.TabStop = false;
            this.companyPicture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // clearInvoiceListboxes
            // 
            this.clearInvoiceListboxes.Location = new System.Drawing.Point(16, 415);
            this.clearInvoiceListboxes.Name = "clearInvoiceListboxes";
            this.clearInvoiceListboxes.Size = new System.Drawing.Size(131, 23);
            this.clearInvoiceListboxes.TabIndex = 15;
            this.clearInvoiceListboxes.Text = "Clear invoice";
            this.clearInvoiceListboxes.UseVisualStyleBackColor = true;
            this.clearInvoiceListboxes.Click += new System.EventHandler(this.clearInvoiceListboxes_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cash",
            "Credit card",
            "Paypal"});
            this.comboBox1.Location = new System.Drawing.Point(20, 210);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Payment type [!]";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 263);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 20);
            this.textBox1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Expire date YYYY-MM-DD";
            // 
            // excelButton
            // 
            this.excelButton.Location = new System.Drawing.Point(36, 343);
            this.excelButton.Name = "excelButton";
            this.excelButton.Size = new System.Drawing.Size(92, 23);
            this.excelButton.TabIndex = 20;
            this.excelButton.Text = "Export to Excel";
            this.excelButton.UseVisualStyleBackColor = true;
            this.excelButton.Click += new System.EventHandler(this.excelButton_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "buyers",
            "companies",
            "cities",
            "countries",
            "proforma_invoices",
            "items",
            "images"});
            this.comboBox2.Location = new System.Drawing.Point(20, 316);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(127, 21);
            this.comboBox2.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Table";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.excelButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.clearInvoiceListboxes);
            this.Controls.Add(this.selectCompanyButton);
            this.Controls.Add(this.invoiceSellerListbox);
            this.Controls.Add(this.invoiceBuyerListbox);
            this.Controls.Add(this.invoiceProductsListbox);
            this.Controls.Add(this.companySettingsPicture);
            this.Controls.Add(this.companyPicture);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.createInvoiceButton);
            this.Controls.Add(this.appNameLabel);
            this.Name = "MainForm";
            this.Text = "Proforma Invoice Maker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companySettingsPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.Button createInvoiceButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox companyPicture;
        private System.Windows.Forms.PictureBox companySettingsPicture;
        public System.Windows.Forms.ListBox invoiceProductsListbox;
        public System.Windows.Forms.ListBox invoiceBuyerListbox;
        public System.Windows.Forms.ListBox invoiceSellerListbox;
        private System.Windows.Forms.Button selectCompanyButton;
        private System.Windows.Forms.Button clearInvoiceListboxes;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button excelButton;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
    }
}

