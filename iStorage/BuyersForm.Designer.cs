namespace iStorage
{
    partial class BuyersForm
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
            this.buyerListbox = new System.Windows.Forms.ListBox();
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.addressTextbox = new System.Windows.Forms.TextBox();
            this.lastNameTextbox = new System.Windows.Forms.TextBox();
            this.phoneTextbox = new System.Windows.Forms.TextBox();
            this.addBuyerButton = new System.Windows.Forms.Button();
            this.selectBuyerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.deleteCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buyerListbox
            // 
            this.buyerListbox.FormattingEnabled = true;
            this.buyerListbox.Location = new System.Drawing.Point(13, 38);
            this.buyerListbox.Name = "buyerListbox";
            this.buyerListbox.ScrollAlwaysVisible = true;
            this.buyerListbox.Size = new System.Drawing.Size(550, 277);
            this.buyerListbox.TabIndex = 0;
            this.buyerListbox.SelectedIndexChanged += new System.EventHandler(this.buyerListbox_SelectedIndexChanged);
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Location = new System.Drawing.Point(17, 379);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextbox.TabIndex = 1;
            // 
            // addressTextbox
            // 
            this.addressTextbox.Location = new System.Drawing.Point(229, 379);
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Size = new System.Drawing.Size(100, 20);
            this.addressTextbox.TabIndex = 2;
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.Location = new System.Drawing.Point(123, 379);
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextbox.TabIndex = 3;
            // 
            // phoneTextbox
            // 
            this.phoneTextbox.Location = new System.Drawing.Point(335, 379);
            this.phoneTextbox.Name = "phoneTextbox";
            this.phoneTextbox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextbox.TabIndex = 4;
            // 
            // addBuyerButton
            // 
            this.addBuyerButton.Location = new System.Drawing.Point(17, 406);
            this.addBuyerButton.Name = "addBuyerButton";
            this.addBuyerButton.Size = new System.Drawing.Size(75, 23);
            this.addBuyerButton.TabIndex = 5;
            this.addBuyerButton.Text = "Add buyer";
            this.addBuyerButton.UseVisualStyleBackColor = true;
            this.addBuyerButton.Click += new System.EventHandler(this.addBuyerButton_Click);
            // 
            // selectBuyerLabel
            // 
            this.selectBuyerLabel.AutoSize = true;
            this.selectBuyerLabel.Location = new System.Drawing.Point(13, 19);
            this.selectBuyerLabel.Name = "selectBuyerLabel";
            this.selectBuyerLabel.Size = new System.Drawing.Size(154, 13);
            this.selectBuyerLabel.TabIndex = 6;
            this.selectBuyerLabel.Text = "Click to select buyer for invoice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add buyer to list";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "First name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Address";
            // 
            // cityComboBox
            // 
            this.cityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(442, 379);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(121, 21);
            this.cityComboBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Phone number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(439, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "City of origin";
            // 
            // deleteCheckbox
            // 
            this.deleteCheckbox.AutoSize = true;
            this.deleteCheckbox.Location = new System.Drawing.Point(123, 412);
            this.deleteCheckbox.Name = "deleteCheckbox";
            this.deleteCheckbox.Size = new System.Drawing.Size(101, 17);
            this.deleteCheckbox.TabIndex = 15;
            this.deleteCheckbox.Text = "Delete from list?";
            this.deleteCheckbox.UseVisualStyleBackColor = true;
            this.deleteCheckbox.CheckedChanged += new System.EventHandler(this.deleteCheckbox_CheckedChanged);
            // 
            // BuyersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 455);
            this.Controls.Add(this.deleteCheckbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectBuyerLabel);
            this.Controls.Add(this.addBuyerButton);
            this.Controls.Add(this.phoneTextbox);
            this.Controls.Add(this.lastNameTextbox);
            this.Controls.Add(this.addressTextbox);
            this.Controls.Add(this.firstNameTextbox);
            this.Controls.Add(this.buyerListbox);
            this.Name = "BuyersForm";
            this.Text = "Select buyer";
            this.Load += new System.EventHandler(this.BuyersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox buyerListbox;
        private System.Windows.Forms.TextBox firstNameTextbox;
        private System.Windows.Forms.TextBox addressTextbox;
        private System.Windows.Forms.TextBox lastNameTextbox;
        private System.Windows.Forms.TextBox phoneTextbox;
        private System.Windows.Forms.Button addBuyerButton;
        private System.Windows.Forms.Label selectBuyerLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox deleteCheckbox;
    }
}