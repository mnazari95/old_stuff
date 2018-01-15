namespace CSIS3540FinalProject
{
    partial class mainCustScreen
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
            this.testBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(82, 42);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(111, 76);
            this.testBtn.TabIndex = 0;
            this.testBtn.Text = "SHOW ME INFO";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // mainCustScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.testBtn);
            this.Name = "mainCustScreen";
            this.Text = "mainCustScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testBtn;
    }
}