namespace iStorage
{
    partial class SellerForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sellerCityComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.selectBuyerLabel = new System.Windows.Forms.Label();
            this.addSellerButton = new System.Windows.Forms.Button();
            this.sellerPhoneTextbox = new System.Windows.Forms.TextBox();
            this.sellerAddressTextbox = new System.Windows.Forms.TextBox();
            this.sellerNameTextbox = new System.Windows.Forms.TextBox();
            this.sellerListbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "City of origin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Phone";
            // 
            // sellerCityComboBox
            // 
            this.sellerCityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sellerCityComboBox.FormattingEnabled = true;
            this.sellerCityComboBox.Location = new System.Drawing.Point(336, 374);
            this.sellerCityComboBox.Name = "sellerCityComboBox";
            this.sellerCityComboBox.Size = new System.Drawing.Size(121, 21);
            this.sellerCityComboBox.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(11, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Add seller to list";
            // 
            // selectBuyerLabel
            // 
            this.selectBuyerLabel.AutoSize = true;
            this.selectBuyerLabel.Location = new System.Drawing.Point(12, 14);
            this.selectBuyerLabel.Name = "selectBuyerLabel";
            this.selectBuyerLabel.Size = new System.Drawing.Size(152, 13);
            this.selectBuyerLabel.TabIndex = 21;
            this.selectBuyerLabel.Text = "Click to select seller for invoice";
            // 
            // addSellerButton
            // 
            this.addSellerButton.Location = new System.Drawing.Point(16, 401);
            this.addSellerButton.Name = "addSellerButton";
            this.addSellerButton.Size = new System.Drawing.Size(75, 23);
            this.addSellerButton.TabIndex = 20;
            this.addSellerButton.Text = "Add seller";
            this.addSellerButton.UseVisualStyleBackColor = true;
            this.addSellerButton.Click += new System.EventHandler(this.addSellerButton_Click);
            // 
            // sellerPhoneTextbox
            // 
            this.sellerPhoneTextbox.Location = new System.Drawing.Point(229, 374);
            this.sellerPhoneTextbox.Name = "sellerPhoneTextbox";
            this.sellerPhoneTextbox.Size = new System.Drawing.Size(100, 20);
            this.sellerPhoneTextbox.TabIndex = 19;
            // 
            // sellerAddressTextbox
            // 
            this.sellerAddressTextbox.Location = new System.Drawing.Point(123, 374);
            this.sellerAddressTextbox.Name = "sellerAddressTextbox";
            this.sellerAddressTextbox.Size = new System.Drawing.Size(100, 20);
            this.sellerAddressTextbox.TabIndex = 17;
            // 
            // sellerNameTextbox
            // 
            this.sellerNameTextbox.Location = new System.Drawing.Point(16, 374);
            this.sellerNameTextbox.Name = "sellerNameTextbox";
            this.sellerNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.sellerNameTextbox.TabIndex = 16;
            // 
            // sellerListbox
            // 
            this.sellerListbox.FormattingEnabled = true;
            this.sellerListbox.Location = new System.Drawing.Point(12, 33);
            this.sellerListbox.Name = "sellerListbox";
            this.sellerListbox.Size = new System.Drawing.Size(550, 277);
            this.sellerListbox.TabIndex = 15;
            this.sellerListbox.SelectedIndexChanged += new System.EventHandler(this.sellerListbox_SelectedIndexChanged);
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sellerCityComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectBuyerLabel);
            this.Controls.Add(this.addSellerButton);
            this.Controls.Add(this.sellerPhoneTextbox);
            this.Controls.Add(this.sellerAddressTextbox);
            this.Controls.Add(this.sellerNameTextbox);
            this.Controls.Add(this.sellerListbox);
            this.Name = "SellerForm";
            this.Text = "Select seller";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox sellerCityComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label selectBuyerLabel;
        private System.Windows.Forms.Button addSellerButton;
        private System.Windows.Forms.TextBox sellerPhoneTextbox;
        private System.Windows.Forms.TextBox sellerAddressTextbox;
        private System.Windows.Forms.TextBox sellerNameTextbox;
        private System.Windows.Forms.ListBox sellerListbox;
    }
}