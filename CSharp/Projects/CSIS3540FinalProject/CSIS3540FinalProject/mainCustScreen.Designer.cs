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
            this.greetingLabel = new System.Windows.Forms.Label();
            this.mainScreenView = new System.Windows.Forms.DataGridView();
            this.viewOrderBtn = new System.Windows.Forms.Button();
            this.createNewOrderBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.curTotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainScreenView)).BeginInit();
            this.SuspendLayout();
            // 
            // greetingLabel
            // 
            this.greetingLabel.AutoSize = true;
            this.greetingLabel.Location = new System.Drawing.Point(9, 9);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(255, 13);
            this.greetingLabel.TabIndex = 0;
            this.greetingLabel.Text = "Hello *CUSTOMER NAME*, please select an option:";
            // 
            // mainScreenView
            // 
            this.mainScreenView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainScreenView.Location = new System.Drawing.Point(12, 34);
            this.mainScreenView.Name = "mainScreenView";
            this.mainScreenView.Size = new System.Drawing.Size(153, 215);
            this.mainScreenView.TabIndex = 1;
            // 
            // viewOrderBtn
            // 
            this.viewOrderBtn.Location = new System.Drawing.Point(171, 226);
            this.viewOrderBtn.Name = "viewOrderBtn";
            this.viewOrderBtn.Size = new System.Drawing.Size(75, 23);
            this.viewOrderBtn.TabIndex = 2;
            this.viewOrderBtn.Text = "View Order";
            this.viewOrderBtn.UseVisualStyleBackColor = true;
            this.viewOrderBtn.Click += new System.EventHandler(this.viewOrderBtn_Click);
            // 
            // createNewOrderBtn
            // 
            this.createNewOrderBtn.Location = new System.Drawing.Point(386, 8);
            this.createNewOrderBtn.Name = "createNewOrderBtn";
            this.createNewOrderBtn.Size = new System.Drawing.Size(132, 56);
            this.createNewOrderBtn.TabIndex = 3;
            this.createNewOrderBtn.Text = "Create New Storage Order";
            this.createNewOrderBtn.UseVisualStyleBackColor = true;
            this.createNewOrderBtn.Click += new System.EventHandler(this.createNewOrderBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(443, 226);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.Location = new System.Drawing.Point(168, 164);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(99, 59);
            this.instructionsLabel.TabIndex = 5;
            this.instructionsLabel.Text = "Select an Invoice Number, then press \"View Order\" to view the Invoice";
            // 
            // curTotalLabel
            // 
            this.curTotalLabel.Location = new System.Drawing.Point(168, 34);
            this.curTotalLabel.Name = "curTotalLabel";
            this.curTotalLabel.Size = new System.Drawing.Size(114, 78);
            this.curTotalLabel.TabIndex = 6;
            this.curTotalLabel.Text = "Current Total for your Storage Orders:";
            // 
            // mainCustScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 261);
            this.Controls.Add(this.curTotalLabel);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.createNewOrderBtn);
            this.Controls.Add(this.viewOrderBtn);
            this.Controls.Add(this.mainScreenView);
            this.Controls.Add(this.greetingLabel);
            this.Name = "mainCustScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Customer Portal";
            this.Load += new System.EventHandler(this.mainCustScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainScreenView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greetingLabel;
        private System.Windows.Forms.DataGridView mainScreenView;
        private System.Windows.Forms.Button viewOrderBtn;
        private System.Windows.Forms.Button createNewOrderBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Label curTotalLabel;
    }
}