namespace DigitalSolutions___Prototype1___SB
{
    partial class createInvoiceForm
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
            this.printInvoiceButton = new System.Windows.Forms.Button();
            this.viewInvoiceButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.optionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // printInvoiceButton
            // 
            this.printInvoiceButton.Location = new System.Drawing.Point(138, 58);
            this.printInvoiceButton.Name = "printInvoiceButton";
            this.printInvoiceButton.Size = new System.Drawing.Size(89, 23);
            this.printInvoiceButton.TabIndex = 0;
            this.printInvoiceButton.Text = "Print Invoice";
            this.printInvoiceButton.UseVisualStyleBackColor = true;
            this.printInvoiceButton.Click += new System.EventHandler(this.printInvoiceButton_Click);
            // 
            // viewInvoiceButton
            // 
            this.viewInvoiceButton.Location = new System.Drawing.Point(138, 29);
            this.viewInvoiceButton.Name = "viewInvoiceButton";
            this.viewInvoiceButton.Size = new System.Drawing.Size(89, 23);
            this.viewInvoiceButton.TabIndex = 1;
            this.viewInvoiceButton.Text = "View Invoice";
            this.viewInvoiceButton.UseVisualStyleBackColor = true;
            this.viewInvoiceButton.Click += new System.EventHandler(this.viewInvoiceButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 86);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // optionLabel
            // 
            this.optionLabel.AutoSize = true;
            this.optionLabel.Location = new System.Drawing.Point(12, 29);
            this.optionLabel.Name = "optionLabel";
            this.optionLabel.Size = new System.Drawing.Size(120, 13);
            this.optionLabel.TabIndex = 3;
            this.optionLabel.Text = "Please select an option:";
            // 
            // createInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 127);
            this.Controls.Add(this.optionLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.viewInvoiceButton);
            this.Controls.Add(this.printInvoiceButton);
            this.Name = "createInvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Solutions - Create Invoice Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button printInvoiceButton;
        private System.Windows.Forms.Button viewInvoiceButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label optionLabel;
    }
}