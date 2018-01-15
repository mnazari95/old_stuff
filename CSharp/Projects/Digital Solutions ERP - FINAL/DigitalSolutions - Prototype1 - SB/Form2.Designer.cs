namespace DigitalSolutions___Prototype1___SB
{
    partial class mainScreenFormAdmin
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
            this.createProjectButton = new System.Windows.Forms.Button();
            this.selectProjectButton = new System.Windows.Forms.Button();
            this.archiveProjectButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.employeeListingButton = new System.Windows.Forms.Button();
            this.mainScreenListView = new System.Windows.Forms.ListView();
            this.projectCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProjectName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.shortDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // createProjectButton
            // 
            this.createProjectButton.Location = new System.Drawing.Point(12, 12);
            this.createProjectButton.Name = "createProjectButton";
            this.createProjectButton.Size = new System.Drawing.Size(94, 26);
            this.createProjectButton.TabIndex = 0;
            this.createProjectButton.Text = "Create Project";
            this.createProjectButton.UseVisualStyleBackColor = true;
            this.createProjectButton.Click += new System.EventHandler(this.createProjectButton_Click);
            // 
            // selectProjectButton
            // 
            this.selectProjectButton.Location = new System.Drawing.Point(12, 44);
            this.selectProjectButton.Name = "selectProjectButton";
            this.selectProjectButton.Size = new System.Drawing.Size(94, 23);
            this.selectProjectButton.TabIndex = 1;
            this.selectProjectButton.Text = "Select Project";
            this.selectProjectButton.UseVisualStyleBackColor = true;
            this.selectProjectButton.Click += new System.EventHandler(this.editProjectButton_Click);
            // 
            // archiveProjectButton
            // 
            this.archiveProjectButton.Enabled = false;
            this.archiveProjectButton.Location = new System.Drawing.Point(12, 73);
            this.archiveProjectButton.Name = "archiveProjectButton";
            this.archiveProjectButton.Size = new System.Drawing.Size(94, 23);
            this.archiveProjectButton.TabIndex = 2;
            this.archiveProjectButton.Text = "Archive Project";
            this.archiveProjectButton.UseVisualStyleBackColor = true;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(12, 131);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(94, 23);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // employeeListingButton
            // 
            this.employeeListingButton.Location = new System.Drawing.Point(12, 102);
            this.employeeListingButton.Name = "employeeListingButton";
            this.employeeListingButton.Size = new System.Drawing.Size(94, 23);
            this.employeeListingButton.TabIndex = 6;
            this.employeeListingButton.Text = "Employee Listing";
            this.employeeListingButton.UseVisualStyleBackColor = true;
            this.employeeListingButton.Click += new System.EventHandler(this.employeeListingButton_Click);
            // 
            // mainScreenListView
            // 
            this.mainScreenListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.projectCode,
            this.columnHeaderProjectName,
            this.clientName,
            this.shortDesc,
            this.startDate});
            this.mainScreenListView.FullRowSelect = true;
            this.mainScreenListView.Location = new System.Drawing.Point(151, 12);
            this.mainScreenListView.Name = "mainScreenListView";
            this.mainScreenListView.Size = new System.Drawing.Size(743, 405);
            this.mainScreenListView.TabIndex = 7;
            this.mainScreenListView.UseCompatibleStateImageBehavior = false;
            this.mainScreenListView.View = System.Windows.Forms.View.Details;
            // 
            // projectCode
            // 
            this.projectCode.Text = "Project Code";
            this.projectCode.Width = 118;
            // 
            // columnHeaderProjectName
            // 
            this.columnHeaderProjectName.Text = "Project Name";
            this.columnHeaderProjectName.Width = 116;
            // 
            // clientName
            // 
            this.clientName.Text = "Client Name";
            this.clientName.Width = 119;
            // 
            // shortDesc
            // 
            this.shortDesc.Text = "Short Description";
            this.shortDesc.Width = 213;
            // 
            // startDate
            // 
            this.startDate.Text = "Start Date";
            this.startDate.Width = 171;
            // 
            // mainScreenFormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 429);
            this.Controls.Add(this.mainScreenListView);
            this.Controls.Add(this.employeeListingButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.archiveProjectButton);
            this.Controls.Add(this.selectProjectButton);
            this.Controls.Add(this.createProjectButton);
            this.Name = "mainScreenFormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Solutions - Main Screen";
            this.Load += new System.EventHandler(this.mainScreenFormAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createProjectButton;
        private System.Windows.Forms.Button selectProjectButton;
        private System.Windows.Forms.Button archiveProjectButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button employeeListingButton;
        private System.Windows.Forms.ListView mainScreenListView;
        private System.Windows.Forms.ColumnHeader projectCode;
        private System.Windows.Forms.ColumnHeader columnHeaderProjectName;
        private System.Windows.Forms.ColumnHeader clientName;
        private System.Windows.Forms.ColumnHeader shortDesc;
        private System.Windows.Forms.ColumnHeader startDate;
    }
}