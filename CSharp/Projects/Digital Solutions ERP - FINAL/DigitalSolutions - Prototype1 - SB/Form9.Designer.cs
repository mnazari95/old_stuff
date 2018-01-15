namespace DigitalSolutions___Prototype1___SB
{
    partial class createEmployeeForm
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
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.jobTitleTextBox = new System.Windows.Forms.TextBox();
            this.skillTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fullTimeGroupBox = new System.Windows.Forms.GroupBox();
            this.fullTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.backButton = new System.Windows.Forms.Button();
            this.createEmployeeButton = new System.Windows.Forms.Button();
            this.fullTimeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(72, 27);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(160, 20);
            this.fullNameTextBox.TabIndex = 1;
            // 
            // jobTitleTextBox
            // 
            this.jobTitleTextBox.Location = new System.Drawing.Point(72, 56);
            this.jobTitleTextBox.Name = "jobTitleTextBox";
            this.jobTitleTextBox.Size = new System.Drawing.Size(160, 20);
            this.jobTitleTextBox.TabIndex = 3;
            // 
            // skillTextBox
            // 
            this.skillTextBox.Location = new System.Drawing.Point(72, 83);
            this.skillTextBox.Name = "skillTextBox";
            this.skillTextBox.Size = new System.Drawing.Size(160, 20);
            this.skillTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Full Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Job Title:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Skills:";
            // 
            // fullTimeGroupBox
            // 
            this.fullTimeGroupBox.Controls.Add(this.fullTimeCheckBox);
            this.fullTimeGroupBox.Location = new System.Drawing.Point(12, 109);
            this.fullTimeGroupBox.Name = "fullTimeGroupBox";
            this.fullTimeGroupBox.Size = new System.Drawing.Size(102, 46);
            this.fullTimeGroupBox.TabIndex = 12;
            this.fullTimeGroupBox.TabStop = false;
            this.fullTimeGroupBox.Text = "Full Time:";
            // 
            // fullTimeCheckBox
            // 
            this.fullTimeCheckBox.AutoSize = true;
            this.fullTimeCheckBox.Location = new System.Drawing.Point(13, 19);
            this.fullTimeCheckBox.Name = "fullTimeCheckBox";
            this.fullTimeCheckBox.Size = new System.Drawing.Size(68, 17);
            this.fullTimeCheckBox.TabIndex = 0;
            this.fullTimeCheckBox.Text = "Full Time";
            this.fullTimeCheckBox.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 161);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // createEmployeeButton
            // 
            this.createEmployeeButton.Location = new System.Drawing.Point(168, 161);
            this.createEmployeeButton.Name = "createEmployeeButton";
            this.createEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.createEmployeeButton.TabIndex = 14;
            this.createEmployeeButton.Text = "Add";
            this.createEmployeeButton.UseVisualStyleBackColor = true;
            this.createEmployeeButton.Click += new System.EventHandler(this.createEmployeeButton_Click);
            // 
            // createEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 197);
            this.Controls.Add(this.createEmployeeButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.fullTimeGroupBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.skillTextBox);
            this.Controls.Add(this.jobTitleTextBox);
            this.Controls.Add(this.fullNameTextBox);
            this.Name = "createEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter New Employee";
            this.fullTimeGroupBox.ResumeLayout(false);
            this.fullTimeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox jobTitleTextBox;
        private System.Windows.Forms.TextBox skillTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox fullTimeGroupBox;
        private System.Windows.Forms.CheckBox fullTimeCheckBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button createEmployeeButton;
    }
}