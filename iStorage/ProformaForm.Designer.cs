namespace iStorage
{
    partial class ProformaForm
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
            this.proformaRichBox = new System.Windows.Forms.RichTextBox();
            this.printButton = new System.Windows.Forms.Button();
            this.pdfButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // proformaRichBox
            // 
            this.proformaRichBox.Location = new System.Drawing.Point(12, 12);
            this.proformaRichBox.Name = "proformaRichBox";
            this.proformaRichBox.Size = new System.Drawing.Size(470, 509);
            this.proformaRichBox.TabIndex = 0;
            this.proformaRichBox.Text = "";
            this.proformaRichBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(13, 528);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 1;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // pdfButton
            // 
            this.pdfButton.Location = new System.Drawing.Point(94, 527);
            this.pdfButton.Name = "pdfButton";
            this.pdfButton.Size = new System.Drawing.Size(90, 23);
            this.pdfButton.TabIndex = 2;
            this.pdfButton.Text = "Export as PDF";
            this.pdfButton.UseVisualStyleBackColor = true;
            this.pdfButton.Click += new System.EventHandler(this.pdfButton_Click);
            // 
            // ProformaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 562);
            this.Controls.Add(this.pdfButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.proformaRichBox);
            this.Name = "ProformaForm";
            this.Text = "Result";
            this.Load += new System.EventHandler(this.ProformaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox proformaRichBox;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button pdfButton;
    }
}