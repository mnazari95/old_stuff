namespace DigitalSolutions___Prototype1___SB
{
    partial class employeeListingForm
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
            this.backButton = new System.Windows.Forms.Button();
            this.createEmployeeButton = new System.Windows.Forms.Button();
            this.deactivateEmployeeButton = new System.Windows.Forms.Button();
            this.employeeListingListView = new System.Windows.Forms.ListView();
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jobTitleHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.skillsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(3, 226);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // createEmployeeButton
            // 
            this.createEmployeeButton.Location = new System.Drawing.Point(171, 226);
            this.createEmployeeButton.Name = "createEmployeeButton";
            this.createEmployeeButton.Size = new System.Drawing.Size(99, 23);
            this.createEmployeeButton.TabIndex = 1;
            this.createEmployeeButton.Text = "Create Employee";
            this.createEmployeeButton.UseVisualStyleBackColor = true;
            this.createEmployeeButton.Click += new System.EventHandler(this.createEmployeeButton_Click);
            // 
            // deactivateEmployeeButton
            // 
            this.deactivateEmployeeButton.Location = new System.Drawing.Point(276, 226);
            this.deactivateEmployeeButton.Name = "deactivateEmployeeButton";
            this.deactivateEmployeeButton.Size = new System.Drawing.Size(117, 23);
            this.deactivateEmployeeButton.TabIndex = 2;
            this.deactivateEmployeeButton.Text = "Deactivate Employee";
            this.deactivateEmployeeButton.UseVisualStyleBackColor = true;
            this.deactivateEmployeeButton.Click += new System.EventHandler(this.deactivateEmployeeButton_Click);
            // 
            // employeeListingListView
            // 
            this.employeeListingListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader,
            this.jobTitleHeader,
            this.skillsHeader});
            this.employeeListingListView.FullRowSelect = true;
            this.employeeListingListView.Location = new System.Drawing.Point(12, 12);
            this.employeeListingListView.Name = "employeeListingListView";
            this.employeeListingListView.Size = new System.Drawing.Size(381, 208);
            this.employeeListingListView.TabIndex = 4;
            this.employeeListingListView.UseCompatibleStateImageBehavior = false;
            this.employeeListingListView.View = System.Windows.Forms.View.Details;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Employee Name";
            this.nameHeader.Width = 101;
            // 
            // jobTitleHeader
            // 
            this.jobTitleHeader.Text = "Job Title";
            this.jobTitleHeader.Width = 131;
            // 
            // skillsHeader
            // 
            this.skillsHeader.Text = "Skills";
            this.skillsHeader.Width = 145;
            // 
            // employeeListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 261);
            this.Controls.Add(this.employeeListingListView);
            this.Controls.Add(this.deactivateEmployeeButton);
            this.Controls.Add(this.createEmployeeButton);
            this.Controls.Add(this.backButton);
            this.Name = "employeeListingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Solutions - Employee Listing";
            this.Load += new System.EventHandler(this.employeeListingForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button createEmployeeButton;
        private System.Windows.Forms.Button deactivateEmployeeButton;
        private System.Windows.Forms.ListView employeeListingListView;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader jobTitleHeader;
        private System.Windows.Forms.ColumnHeader skillsHeader;
    }
}