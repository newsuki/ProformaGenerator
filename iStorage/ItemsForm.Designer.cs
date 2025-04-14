namespace iStorage
{
    partial class ItemsForm
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
            this.itemListbox = new System.Windows.Forms.ListBox();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addItemDatabaseButton = new System.Windows.Forms.Button();
            this.addItemInvoiceButton = new System.Windows.Forms.Button();
            this.productNameTextbox = new System.Windows.Forms.TextBox();
            this.priceTextbox = new System.Windows.Forms.TextBox();
            this.productDescriptionTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imageCombobox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.discountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // itemListbox
            // 
            this.itemListbox.FormattingEnabled = true;
            this.itemListbox.Location = new System.Drawing.Point(446, 9);
            this.itemListbox.Name = "itemListbox";
            this.itemListbox.ScrollAlwaysVisible = true;
            this.itemListbox.Size = new System.Drawing.Size(571, 368);
            this.itemListbox.TabIndex = 0;
            this.itemListbox.SelectedIndexChanged += new System.EventHandler(this.itemListbox_SelectedIndexChanged);
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.Location = new System.Drawing.Point(12, 99);
            this.amountNumericUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.amountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(71, 20);
            this.amountNumericUpDown.TabIndex = 1;
            this.amountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountNumericUpDown.ValueChanged += new System.EventHandler(this.amountNumericUpDown_ValueChanged);
            // 
            // addItemDatabaseButton
            // 
            this.addItemDatabaseButton.Location = new System.Drawing.Point(12, 339);
            this.addItemDatabaseButton.Name = "addItemDatabaseButton";
            this.addItemDatabaseButton.Size = new System.Drawing.Size(199, 41);
            this.addItemDatabaseButton.TabIndex = 2;
            this.addItemDatabaseButton.Text = "Insert item into database";
            this.addItemDatabaseButton.UseVisualStyleBackColor = true;
            this.addItemDatabaseButton.Click += new System.EventHandler(this.addItemDatabaseButton_Click);
            // 
            // addItemInvoiceButton
            // 
            this.addItemInvoiceButton.Location = new System.Drawing.Point(12, 125);
            this.addItemInvoiceButton.Name = "addItemInvoiceButton";
            this.addItemInvoiceButton.Size = new System.Drawing.Size(199, 37);
            this.addItemInvoiceButton.TabIndex = 3;
            this.addItemInvoiceButton.Text = "Add item to invoice";
            this.addItemInvoiceButton.UseVisualStyleBackColor = true;
            this.addItemInvoiceButton.Click += new System.EventHandler(this.addItemInvoiceButton_Click);
            // 
            // productNameTextbox
            // 
            this.productNameTextbox.Location = new System.Drawing.Point(12, 182);
            this.productNameTextbox.Name = "productNameTextbox";
            this.productNameTextbox.Size = new System.Drawing.Size(199, 20);
            this.productNameTextbox.TabIndex = 4;
            // 
            // priceTextbox
            // 
            this.priceTextbox.Location = new System.Drawing.Point(12, 226);
            this.priceTextbox.Name = "priceTextbox";
            this.priceTextbox.Size = new System.Drawing.Size(199, 20);
            this.priceTextbox.TabIndex = 5;
            // 
            // productDescriptionTextbox
            // 
            this.productDescriptionTextbox.Location = new System.Drawing.Point(12, 265);
            this.productDescriptionTextbox.Name = "productDescriptionTextbox";
            this.productDescriptionTextbox.Size = new System.Drawing.Size(199, 20);
            this.productDescriptionTextbox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Items";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Product name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Product price";
            // 
            // imageCombobox
            // 
            this.imageCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imageCombobox.FormattingEnabled = true;
            this.imageCombobox.Location = new System.Drawing.Point(15, 312);
            this.imageCombobox.Name = "imageCombobox";
            this.imageCombobox.Size = new System.Drawing.Size(121, 21);
            this.imageCombobox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Image";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(218, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 301);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.Location = new System.Drawing.Point(330, 9);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(110, 23);
            this.deleteItemButton.TabIndex = 19;
            this.deleteItemButton.Text = "DELETE ITEM";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            this.deleteItemButton.Click += new System.EventHandler(this.deleteItemButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(218, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 20;
            // 
            // discountNumericUpDown
            // 
            this.discountNumericUpDown.Location = new System.Drawing.Point(150, 99);
            this.discountNumericUpDown.Name = "discountNumericUpDown";
            this.discountNumericUpDown.Size = new System.Drawing.Size(61, 20);
            this.discountNumericUpDown.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Discount (%)";
            // 
            // ItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 394);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.discountNumericUpDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.deleteItemButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.imageCombobox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productDescriptionTextbox);
            this.Controls.Add(this.priceTextbox);
            this.Controls.Add(this.productNameTextbox);
            this.Controls.Add(this.addItemInvoiceButton);
            this.Controls.Add(this.addItemDatabaseButton);
            this.Controls.Add(this.amountNumericUpDown);
            this.Controls.Add(this.itemListbox);
            this.Name = "ItemsForm";
            this.Text = "Select products";
            this.Load += new System.EventHandler(this.ItemsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox itemListbox;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
        private System.Windows.Forms.Button addItemDatabaseButton;
        private System.Windows.Forms.Button addItemInvoiceButton;
        private System.Windows.Forms.TextBox productNameTextbox;
        private System.Windows.Forms.TextBox priceTextbox;
        private System.Windows.Forms.TextBox productDescriptionTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox imageCombobox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown discountNumericUpDown;
        private System.Windows.Forms.Label label5;
    }
}