namespace CSIS3540FinalProject
{
    partial class newCustItemForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.lengthText = new System.Windows.Forms.TextBox();
            this.widthText = new System.Windows.Forms.TextBox();
            this.heightText = new System.Windows.Forms.TextBox();
            this.quantityText = new System.Windows.Forms.TextBox();
            this.weightText = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 41);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(164, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name/Short Description of Items:";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(12, 80);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(131, 13);
            this.lengthLabel.TabIndex = 1;
            this.lengthLabel.Text = "Container Length (inches):";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(12, 119);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(126, 13);
            this.widthLabel.TabIndex = 2;
            this.widthLabel.Text = "Container Width (inches):";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(12, 158);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(129, 13);
            this.heightLabel.TabIndex = 3;
            this.heightLabel.Text = "Container Height (inches):";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(12, 197);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(72, 13);
            this.quantityLabel.TabIndex = 4;
            this.quantityLabel.Text = "Item Quantity:";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(12, 236);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(114, 13);
            this.weightLabel.TabIndex = 5;
            this.weightLabel.Text = "Container Weight (lbs):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(373, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Please fill out the below information for each Container you would like to store:" +
    "";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(15, 57);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(274, 20);
            this.nameText.TabIndex = 0;
            // 
            // lengthText
            // 
            this.lengthText.Location = new System.Drawing.Point(15, 96);
            this.lengthText.Name = "lengthText";
            this.lengthText.Size = new System.Drawing.Size(274, 20);
            this.lengthText.TabIndex = 1;
            // 
            // widthText
            // 
            this.widthText.Location = new System.Drawing.Point(15, 135);
            this.widthText.Name = "widthText";
            this.widthText.Size = new System.Drawing.Size(274, 20);
            this.widthText.TabIndex = 2;
            // 
            // heightText
            // 
            this.heightText.Location = new System.Drawing.Point(15, 174);
            this.heightText.Name = "heightText";
            this.heightText.Size = new System.Drawing.Size(274, 20);
            this.heightText.TabIndex = 3;
            // 
            // quantityText
            // 
            this.quantityText.Location = new System.Drawing.Point(15, 213);
            this.quantityText.Name = "quantityText";
            this.quantityText.Size = new System.Drawing.Size(274, 20);
            this.quantityText.TabIndex = 4;
            // 
            // weightText
            // 
            this.weightText.Location = new System.Drawing.Point(15, 252);
            this.weightText.Name = "weightText";
            this.weightText.Size = new System.Drawing.Size(274, 20);
            this.weightText.TabIndex = 5;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(12, 278);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 33);
            this.submitBtn.TabIndex = 6;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // newCustItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 323);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.weightText);
            this.Controls.Add(this.quantityText);
            this.Controls.Add(this.heightText);
            this.Controls.Add(this.widthText);
            this.Controls.Add(this.lengthText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "newCustItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Storage Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox lengthText;
        private System.Windows.Forms.TextBox widthText;
        private System.Windows.Forms.TextBox heightText;
        private System.Windows.Forms.TextBox quantityText;
        private System.Windows.Forms.TextBox weightText;
        private System.Windows.Forms.Button submitBtn;
    }
}