namespace iStorage
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.appNameLabel = new System.Windows.Forms.Label();
            this.createInvoiceButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.companyPicture = new System.Windows.Forms.PictureBox();
            this.companySettingsPicture = new System.Windows.Forms.PictureBox();
            this.invoiceProductsListbox = new System.Windows.Forms.ListBox();
            this.invoiceBuyerListbox = new System.Windows.Forms.ListBox();
            this.sellerBuyerListbox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.companyPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companySettingsPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Yu Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.appNameLabel.Location = new System.Drawing.Point(12, 12);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(429, 45);
            this.appNameLabel.TabIndex = 0;
            this.appNameLabel.Text = "Proforma Invoice Maker";
            this.appNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // createInvoiceButton
            // 
            this.createInvoiceButton.Location = new System.Drawing.Point(16, 145);
            this.createInvoiceButton.Name = "createInvoiceButton";
            this.createInvoiceButton.Size = new System.Drawing.Size(131, 49);
            this.createInvoiceButton.TabIndex = 3;
            this.createInvoiceButton.Text = "Create proforma invoice";
            this.createInvoiceButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Select products";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 25);
            this.button2.TabIndex = 5;
            this.button2.Text = "Select buyer";
            this.button2.UseVisualStyleBackColor = true;
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
            // invoiceProductsListbox
            // 
            this.invoiceProductsListbox.FormattingEnabled = true;
            this.invoiceProductsListbox.Location = new System.Drawing.Point(153, 83);
            this.invoiceProductsListbox.Name = "invoiceProductsListbox";
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
            // sellerBuyerListbox
            // 
            this.sellerBuyerListbox.FormattingEnabled = true;
            this.sellerBuyerListbox.Location = new System.Drawing.Point(321, 210);
            this.sellerBuyerListbox.Name = "sellerBuyerListbox";
            this.sellerBuyerListbox.Size = new System.Drawing.Size(245, 121);
            this.sellerBuyerListbox.TabIndex = 12;
            this.sellerBuyerListbox.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(437, 428);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Adrian Karahmetović 2025";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sellerBuyerListbox);
            this.Controls.Add(this.invoiceBuyerListbox);
            this.Controls.Add(this.invoiceProductsListbox);
            this.Controls.Add(this.companySettingsPicture);
            this.Controls.Add(this.companyPicture);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.createInvoiceButton);
            this.Controls.Add(this.appNameLabel);
            this.Name = "mainForm";
            this.Text = "Proforma Invoice Maker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companyPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companySettingsPicture)).EndInit();
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
        private System.Windows.Forms.ListBox invoiceProductsListbox;
        private System.Windows.Forms.ListBox invoiceBuyerListbox;
        private System.Windows.Forms.ListBox sellerBuyerListbox;
        private System.Windows.Forms.Label label2;
    }
}

