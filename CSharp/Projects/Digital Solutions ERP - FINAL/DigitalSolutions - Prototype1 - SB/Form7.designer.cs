namespace DigitalSolutions___Prototype1___SB
{
    partial class mainScreenFormEmployee
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
            this.editProjectButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.employeeListView = new System.Windows.Forms.ListView();
            this.projectCodeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.projectNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clientNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.shortDescHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startDateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            // editProjectButton
            // 
            this.editProjectButton.Location = new System.Drawing.Point(12, 44);
            this.editProjectButton.Name = "editProjectButton";
            this.editProjectButton.Size = new System.Drawing.Size(94, 23);
            this.editProjectButton.TabIndex = 1;
            this.editProjectButton.Text = "Select Project";
            this.editProjectButton.UseVisualStyleBackColor = true;
            this.editProjectButton.Click += new System.EventHandler(this.editProjectButton_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(12, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Archive Project";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(12, 102);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(94, 23);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // employeeListView
            // 
            this.employeeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.projectCodeHeader,
            this.projectNameHeader,
            this.clientNameHeader,
            this.shortDescHeader,
            this.startDateHeader});
            this.employeeListView.FullRowSelect = true;
            this.employeeListView.Location = new System.Drawing.Point(113, 12);
            this.employeeListView.MultiSelect = false;
            this.employeeListView.Name = "employeeListView";
            this.employeeListView.Size = new System.Drawing.Size(635, 297);
            this.employeeListView.TabIndex = 5;
            this.employeeListView.UseCompatibleStateImageBehavior = false;
            this.employeeListView.View = System.Windows.Forms.View.Details;
            // 
            // projectCodeHeader
            // 
            this.projectCodeHeader.Text = "Project Code";
            this.projectCodeHeader.Width = 100;
            // 
            // projectNameHeader
            // 
            this.projectNameHeader.Text = "Project Name";
            this.projectNameHeader.Width = 125;
            // 
            // clientNameHeader
            // 
            this.clientNameHeader.Text = "Client Name";
            this.clientNameHeader.Width = 100;
            // 
            // shortDescHeader
            // 
            this.shortDescHeader.Text = "Short Description";
            this.shortDescHeader.Width = 150;
            // 
            // startDateHeader
            // 
            this.startDateHeader.Text = "Start Date";
            this.startDateHeader.Width = 150;
            // 
            // mainScreenFormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 321);
            this.Controls.Add(this.employeeListView);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.editProjectButton);
            this.Controls.Add(this.createProjectButton);
            this.Name = "mainScreenFormEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Solutions - Main Screen";
            this.Load += new System.EventHandler(this.mainScreenFormEmployee_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createProjectButton;
        private System.Windows.Forms.Button editProjectButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.ListView employeeListView;
        private System.Windows.Forms.ColumnHeader projectCodeHeader;
        private System.Windows.Forms.ColumnHeader projectNameHeader;
        private System.Windows.Forms.ColumnHeader clientNameHeader;
        private System.Windows.Forms.ColumnHeader shortDescHeader;
        private System.Windows.Forms.ColumnHeader startDateHeader;
    }
}