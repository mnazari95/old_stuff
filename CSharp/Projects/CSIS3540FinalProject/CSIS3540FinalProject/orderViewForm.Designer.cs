namespace CSIS3540FinalProject
{
    partial class orderViewForm
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
            this.orderView = new System.Windows.Forms.DataGridView();
            this.retrieveAllOfOneBtn = new System.Windows.Forms.Button();
            this.retrieveXBtn = new System.Windows.Forms.Button();
            this.retrieveInvoiceBtn = new System.Windows.Forms.Button();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderView)).BeginInit();
            this.SuspendLayout();
            // 
            // orderView
            // 
            this.orderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderView.Location = new System.Drawing.Point(12, 26);
            this.orderView.Name = "orderView";
            this.orderView.Size = new System.Drawing.Size(417, 312);
            this.orderView.TabIndex = 0;
            // 
            // retrieveAllOfOneBtn
            // 
            this.retrieveAllOfOneBtn.Location = new System.Drawing.Point(435, 26);
            this.retrieveAllOfOneBtn.Name = "retrieveAllOfOneBtn";
            this.retrieveAllOfOneBtn.Size = new System.Drawing.Size(84, 49);
            this.retrieveAllOfOneBtn.TabIndex = 1;
            this.retrieveAllOfOneBtn.Text = "Retrieve All of one Item";
            this.retrieveAllOfOneBtn.UseVisualStyleBackColor = true;
            this.retrieveAllOfOneBtn.Click += new System.EventHandler(this.retrieveAllOfOneBtn_Click);
            // 
            // retrieveXBtn
            // 
            this.retrieveXBtn.Location = new System.Drawing.Point(435, 93);
            this.retrieveXBtn.Name = "retrieveXBtn";
            this.retrieveXBtn.Size = new System.Drawing.Size(84, 49);
            this.retrieveXBtn.TabIndex = 2;
            this.retrieveXBtn.Text = "Retrieve \"X\" of one Item";
            this.retrieveXBtn.UseVisualStyleBackColor = true;
            this.retrieveXBtn.Click += new System.EventHandler(this.retrieveXBtn_Click);
            // 
            // retrieveInvoiceBtn
            // 
            this.retrieveInvoiceBtn.Location = new System.Drawing.Point(435, 160);
            this.retrieveInvoiceBtn.Name = "retrieveInvoiceBtn";
            this.retrieveInvoiceBtn.Size = new System.Drawing.Size(84, 53);
            this.retrieveInvoiceBtn.TabIndex = 3;
            this.retrieveInvoiceBtn.Text = "Retrieve Entire Invoice";
            this.retrieveInvoiceBtn.UseVisualStyleBackColor = true;
            this.retrieveInvoiceBtn.Click += new System.EventHandler(this.retrieveInvoiceBtn_Click);
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(12, 9);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(390, 13);
            this.instructionsLabel.TabIndex = 4;
            this.instructionsLabel.Text = "Please select an Item Name below, then select an option from the list on the righ" +
    "t:";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(435, 285);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(84, 53);
            this.backBtn.TabIndex = 5;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // orderViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 350);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.retrieveInvoiceBtn);
            this.Controls.Add(this.retrieveXBtn);
            this.Controls.Add(this.retrieveAllOfOneBtn);
            this.Controls.Add(this.orderView);
            this.Name = "orderViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.orderViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView orderView;
        private System.Windows.Forms.Button retrieveAllOfOneBtn;
        private System.Windows.Forms.Button retrieveXBtn;
        private System.Windows.Forms.Button retrieveInvoiceBtn;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Button backBtn;
    }
}