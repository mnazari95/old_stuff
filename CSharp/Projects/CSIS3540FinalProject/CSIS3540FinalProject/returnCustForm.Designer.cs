namespace CSIS3540FinalProject
{
    partial class returnCustForm
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
            this.fNameText = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.lNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(180, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Please Enter Your First Name Below:";
            // 
            // fNameText
            // 
            this.fNameText.Location = new System.Drawing.Point(12, 25);
            this.fNameText.Name = "fNameText";
            this.fNameText.Size = new System.Drawing.Size(190, 20);
            this.fNameText.TabIndex = 0;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(117, 110);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 2;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(12, 110);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // lNameText
            // 
            this.lNameText.Location = new System.Drawing.Point(12, 70);
            this.lNameText.Name = "lNameText";
            this.lNameText.Size = new System.Drawing.Size(190, 20);
            this.lNameText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please Enter Your Last Name Below:";
            // 
            // returnCustForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 153);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lNameText);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.fNameText);
            this.Controls.Add(this.nameLabel);
            this.Name = "returnCustForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Returning Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox fNameText;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox lNameText;
        private System.Windows.Forms.Label label1;
    }
}