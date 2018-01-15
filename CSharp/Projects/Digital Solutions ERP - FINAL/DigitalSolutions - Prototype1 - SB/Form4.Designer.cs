namespace DigitalSolutions___Prototype1___SB
{
    partial class projectScreenForm
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
            this.editProjectButton = new System.Windows.Forms.Button();
            this.createInvoiceButton = new System.Windows.Forms.Button();
            this.pScreenDetailsListView = new System.Windows.Forms.ListView();
            this.projectCodeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.projectNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clientNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.shortDescHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startDateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.billingCycleComboBox = new System.Windows.Forms.ComboBox();
            this.dropDownLabel = new System.Windows.Forms.Label();
            this.hoursRadioButton1 = new System.Windows.Forms.RadioButton();
            this.hoursRadioButton2 = new System.Windows.Forms.RadioButton();
            this.materialsRadioButton1 = new System.Windows.Forms.RadioButton();
            this.materialsRadioButton2 = new System.Windows.Forms.RadioButton();
            this.hoursGroupBox = new System.Windows.Forms.GroupBox();
            this.materialsGroupBox = new System.Windows.Forms.GroupBox();
            this.pScreenEmpListView = new System.Windows.Forms.ListView();
            this.employeeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hoursHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.costsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pScreenTaskListView = new System.Windows.Forms.ListView();
            this.taskHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.taskHoursHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.completedHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newTaskButton = new System.Windows.Forms.Button();
            this.hoursGroupBox.SuspendLayout();
            this.materialsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 350);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // editProjectButton
            // 
            this.editProjectButton.Location = new System.Drawing.Point(373, 350);
            this.editProjectButton.Name = "editProjectButton";
            this.editProjectButton.Size = new System.Drawing.Size(87, 23);
            this.editProjectButton.TabIndex = 1;
            this.editProjectButton.Text = "Edit Project";
            this.editProjectButton.UseVisualStyleBackColor = true;
            this.editProjectButton.Click += new System.EventHandler(this.applyChangesButton_Click);
            // 
            // createInvoiceButton
            // 
            this.createInvoiceButton.Location = new System.Drawing.Point(466, 350);
            this.createInvoiceButton.Name = "createInvoiceButton";
            this.createInvoiceButton.Size = new System.Drawing.Size(91, 23);
            this.createInvoiceButton.TabIndex = 2;
            this.createInvoiceButton.Text = "Create Invoice";
            this.createInvoiceButton.UseVisualStyleBackColor = true;
            this.createInvoiceButton.Click += new System.EventHandler(this.createInvoiceButton_Click);
            // 
            // pScreenDetailsListView
            // 
            this.pScreenDetailsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.projectCodeHeader,
            this.projectNameHeader,
            this.clientNameHeader,
            this.shortDescHeader,
            this.startDateHeader});
            this.pScreenDetailsListView.Location = new System.Drawing.Point(12, 12);
            this.pScreenDetailsListView.Name = "pScreenDetailsListView";
            this.pScreenDetailsListView.Size = new System.Drawing.Size(545, 52);
            this.pScreenDetailsListView.TabIndex = 3;
            this.pScreenDetailsListView.UseCompatibleStateImageBehavior = false;
            this.pScreenDetailsListView.View = System.Windows.Forms.View.Details;
            // 
            // projectCodeHeader
            // 
            this.projectCodeHeader.Text = "Project Code";
            this.projectCodeHeader.Width = 100;
            // 
            // projectNameHeader
            // 
            this.projectNameHeader.Text = "Project Name";
            this.projectNameHeader.Width = 100;
            // 
            // clientNameHeader
            // 
            this.clientNameHeader.Text = "Client Name";
            this.clientNameHeader.Width = 100;
            // 
            // shortDescHeader
            // 
            this.shortDescHeader.Text = "Short Description";
            this.shortDescHeader.Width = 128;
            // 
            // startDateHeader
            // 
            this.startDateHeader.Text = "Start Date";
            this.startDateHeader.Width = 112;
            // 
            // billingCycleComboBox
            // 
            this.billingCycleComboBox.FormattingEnabled = true;
            this.billingCycleComboBox.Items.AddRange(new object[] {
            "Manual",
            "Weekly",
            "Bi-Weekly",
            "Monthly",
            "Semi-Annually",
            "Annually"});
            this.billingCycleComboBox.Location = new System.Drawing.Point(84, 79);
            this.billingCycleComboBox.Name = "billingCycleComboBox";
            this.billingCycleComboBox.Size = new System.Drawing.Size(131, 21);
            this.billingCycleComboBox.TabIndex = 4;
            // 
            // dropDownLabel
            // 
            this.dropDownLabel.AutoSize = true;
            this.dropDownLabel.Location = new System.Drawing.Point(9, 82);
            this.dropDownLabel.Name = "dropDownLabel";
            this.dropDownLabel.Size = new System.Drawing.Size(66, 13);
            this.dropDownLabel.TabIndex = 5;
            this.dropDownLabel.Text = "Billing Cycle:";
            // 
            // hoursRadioButton1
            // 
            this.hoursRadioButton1.AutoSize = true;
            this.hoursRadioButton1.Location = new System.Drawing.Point(19, 19);
            this.hoursRadioButton1.Name = "hoursRadioButton1";
            this.hoursRadioButton1.Size = new System.Drawing.Size(56, 17);
            this.hoursRadioButton1.TabIndex = 6;
            this.hoursRadioButton1.TabStop = true;
            this.hoursRadioButton1.Text = "Payroll";
            this.hoursRadioButton1.UseVisualStyleBackColor = true;
            // 
            // hoursRadioButton2
            // 
            this.hoursRadioButton2.AutoSize = true;
            this.hoursRadioButton2.Location = new System.Drawing.Point(19, 42);
            this.hoursRadioButton2.Name = "hoursRadioButton2";
            this.hoursRadioButton2.Size = new System.Drawing.Size(51, 17);
            this.hoursRadioButton2.TabIndex = 7;
            this.hoursRadioButton2.TabStop = true;
            this.hoursRadioButton2.Text = "Client";
            this.hoursRadioButton2.UseVisualStyleBackColor = true;
            // 
            // materialsRadioButton1
            // 
            this.materialsRadioButton1.AutoSize = true;
            this.materialsRadioButton1.Location = new System.Drawing.Point(16, 19);
            this.materialsRadioButton1.Name = "materialsRadioButton1";
            this.materialsRadioButton1.Size = new System.Drawing.Size(63, 17);
            this.materialsRadioButton1.TabIndex = 8;
            this.materialsRadioButton1.TabStop = true;
            this.materialsRadioButton1.Text = "Flat Fee";
            this.materialsRadioButton1.UseVisualStyleBackColor = true;
            // 
            // materialsRadioButton2
            // 
            this.materialsRadioButton2.AutoSize = true;
            this.materialsRadioButton2.Location = new System.Drawing.Point(16, 42);
            this.materialsRadioButton2.Name = "materialsRadioButton2";
            this.materialsRadioButton2.Size = new System.Drawing.Size(51, 17);
            this.materialsRadioButton2.TabIndex = 9;
            this.materialsRadioButton2.TabStop = true;
            this.materialsRadioButton2.Text = "Client";
            this.materialsRadioButton2.UseVisualStyleBackColor = true;
            // 
            // hoursGroupBox
            // 
            this.hoursGroupBox.Controls.Add(this.hoursRadioButton1);
            this.hoursGroupBox.Controls.Add(this.hoursRadioButton2);
            this.hoursGroupBox.Location = new System.Drawing.Point(12, 106);
            this.hoursGroupBox.Name = "hoursGroupBox";
            this.hoursGroupBox.Size = new System.Drawing.Size(115, 68);
            this.hoursGroupBox.TabIndex = 12;
            this.hoursGroupBox.TabStop = false;
            this.hoursGroupBox.Text = "Hours Billed To:";
            // 
            // materialsGroupBox
            // 
            this.materialsGroupBox.Controls.Add(this.materialsRadioButton1);
            this.materialsGroupBox.Controls.Add(this.materialsRadioButton2);
            this.materialsGroupBox.Location = new System.Drawing.Point(284, 106);
            this.materialsGroupBox.Name = "materialsGroupBox";
            this.materialsGroupBox.Size = new System.Drawing.Size(132, 68);
            this.materialsGroupBox.TabIndex = 13;
            this.materialsGroupBox.TabStop = false;
            this.materialsGroupBox.Text = "Materials Billed To:";
            // 
            // pScreenEmpListView
            // 
            this.pScreenEmpListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.employeeHeader,
            this.hoursHeader,
            this.materialsHeader,
            this.costsHeader});
            this.pScreenEmpListView.Location = new System.Drawing.Point(12, 180);
            this.pScreenEmpListView.Name = "pScreenEmpListView";
            this.pScreenEmpListView.Size = new System.Drawing.Size(545, 78);
            this.pScreenEmpListView.TabIndex = 14;
            this.pScreenEmpListView.UseCompatibleStateImageBehavior = false;
            this.pScreenEmpListView.View = System.Windows.Forms.View.Details;
            // 
            // employeeHeader
            // 
            this.employeeHeader.Text = "Assigned Employees";
            this.employeeHeader.Width = 169;
            // 
            // hoursHeader
            // 
            this.hoursHeader.Text = "Hours Worked";
            this.hoursHeader.Width = 100;
            // 
            // materialsHeader
            // 
            this.materialsHeader.Text = "Materials";
            this.materialsHeader.Width = 143;
            // 
            // costsHeader
            // 
            this.costsHeader.Text = "Cost";
            this.costsHeader.Width = 126;
            // 
            // pScreenTaskListView
            // 
            this.pScreenTaskListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.taskHeader,
            this.taskHoursHeader,
            this.completedHeader});
            this.pScreenTaskListView.Location = new System.Drawing.Point(12, 264);
            this.pScreenTaskListView.Name = "pScreenTaskListView";
            this.pScreenTaskListView.Size = new System.Drawing.Size(545, 80);
            this.pScreenTaskListView.TabIndex = 15;
            this.pScreenTaskListView.UseCompatibleStateImageBehavior = false;
            this.pScreenTaskListView.View = System.Windows.Forms.View.Details;
            // 
            // taskHeader
            // 
            this.taskHeader.Text = "Task Name";
            this.taskHeader.Width = 168;
            // 
            // taskHoursHeader
            // 
            this.taskHoursHeader.Text = "Hours to Complete";
            this.taskHoursHeader.Width = 150;
            // 
            // completedHeader
            // 
            this.completedHeader.Text = "Completed By";
            this.completedHeader.Width = 219;
            // 
            // newTaskButton
            // 
            this.newTaskButton.Location = new System.Drawing.Point(271, 350);
            this.newTaskButton.Name = "newTaskButton";
            this.newTaskButton.Size = new System.Drawing.Size(96, 23);
            this.newTaskButton.TabIndex = 16;
            this.newTaskButton.Text = "Enter New Task";
            this.newTaskButton.UseVisualStyleBackColor = true;
            this.newTaskButton.Click += new System.EventHandler(this.newTaskButton_Click);
            // 
            // projectScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 385);
            this.Controls.Add(this.newTaskButton);
            this.Controls.Add(this.pScreenTaskListView);
            this.Controls.Add(this.pScreenEmpListView);
            this.Controls.Add(this.materialsGroupBox);
            this.Controls.Add(this.hoursGroupBox);
            this.Controls.Add(this.dropDownLabel);
            this.Controls.Add(this.billingCycleComboBox);
            this.Controls.Add(this.pScreenDetailsListView);
            this.Controls.Add(this.createInvoiceButton);
            this.Controls.Add(this.editProjectButton);
            this.Controls.Add(this.backButton);
            this.Name = "projectScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Solutions - Project Screen";
            this.Load += new System.EventHandler(this.projectScreenForm_Load);
            this.hoursGroupBox.ResumeLayout(false);
            this.hoursGroupBox.PerformLayout();
            this.materialsGroupBox.ResumeLayout(false);
            this.materialsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button editProjectButton;
        private System.Windows.Forms.Button createInvoiceButton;
        private System.Windows.Forms.ListView pScreenDetailsListView;
        private System.Windows.Forms.ColumnHeader projectCodeHeader;
        private System.Windows.Forms.ColumnHeader projectNameHeader;
        private System.Windows.Forms.ColumnHeader clientNameHeader;
        private System.Windows.Forms.ColumnHeader shortDescHeader;
        private System.Windows.Forms.ColumnHeader startDateHeader;
        private System.Windows.Forms.ComboBox billingCycleComboBox;
        private System.Windows.Forms.Label dropDownLabel;
        private System.Windows.Forms.RadioButton hoursRadioButton1;
        private System.Windows.Forms.RadioButton hoursRadioButton2;
        private System.Windows.Forms.RadioButton materialsRadioButton1;
        private System.Windows.Forms.RadioButton materialsRadioButton2;
        private System.Windows.Forms.GroupBox hoursGroupBox;
        private System.Windows.Forms.GroupBox materialsGroupBox;
        private System.Windows.Forms.ListView pScreenEmpListView;
        private System.Windows.Forms.ColumnHeader employeeHeader;
        private System.Windows.Forms.ColumnHeader hoursHeader;
        private System.Windows.Forms.ColumnHeader materialsHeader;
        private System.Windows.Forms.ColumnHeader costsHeader;
        private System.Windows.Forms.ListView pScreenTaskListView;
        private System.Windows.Forms.ColumnHeader taskHeader;
        private System.Windows.Forms.ColumnHeader taskHoursHeader;
        private System.Windows.Forms.ColumnHeader completedHeader;
        private System.Windows.Forms.Button newTaskButton;
    }
}