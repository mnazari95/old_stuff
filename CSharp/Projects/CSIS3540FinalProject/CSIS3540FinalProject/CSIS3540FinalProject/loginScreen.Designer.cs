namespace CSIS3540FinalProject
{
    partial class loginScreen
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
            this.newCustBtn = new System.Windows.Forms.Button();
            this.returnCustBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newCustBtn
            // 
            this.newCustBtn.Location = new System.Drawing.Point(12, 12);
            this.newCustBtn.Name = "newCustBtn";
            this.newCustBtn.Size = new System.Drawing.Size(94, 61);
            this.newCustBtn.TabIndex = 0;
            this.newCustBtn.Text = "New Customer";
            this.newCustBtn.UseVisualStyleBackColor = true;
            this.newCustBtn.Click += new System.EventHandler(this.newCustBtn_Click);
            // 
            // returnCustBtn
            // 
            this.returnCustBtn.Location = new System.Drawing.Point(143, 12);
            this.returnCustBtn.Name = "returnCustBtn";
            this.returnCustBtn.Size = new System.Drawing.Size(93, 61);
            this.returnCustBtn.TabIndex = 1;
            this.returnCustBtn.Text = "Returning Customer";
            this.returnCustBtn.UseVisualStyleBackColor = true;
            this.returnCustBtn.Click += new System.EventHandler(this.returnCustBtn_Click);
            // 
            // loginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 104);
            this.Controls.Add(this.returnCustBtn);
            this.Controls.Add(this.newCustBtn);
            this.Name = "loginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Login";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newCustBtn;
        private System.Windows.Forms.Button returnCustBtn;
    }
}

