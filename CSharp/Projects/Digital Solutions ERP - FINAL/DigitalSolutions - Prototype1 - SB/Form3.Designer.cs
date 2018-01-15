namespace DigitalSolutions___Prototype1___SB
{
    partial class projectScreenInputForm
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
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.projectInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.shortDescLabel = new System.Windows.Forms.Label();
            this.shortDescTextBox = new System.Windows.Forms.TextBox();
            this.projectInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.Location = new System.Drawing.Point(103, 23);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(130, 20);
            this.projectNameTextBox.TabIndex = 0;
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.Location = new System.Drawing.Point(103, 46);
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(130, 20);
            this.clientNameTextBox.TabIndex = 1;
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Location = new System.Drawing.Point(23, 26);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(74, 13);
            this.projectNameLabel.TabIndex = 2;
            this.projectNameLabel.Text = "Project Name:";
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.AutoSize = true;
            this.clientNameLabel.Location = new System.Drawing.Point(30, 49);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(67, 13);
            this.clientNameLabel.TabIndex = 3;
            this.clientNameLabel.Text = "Client Name:";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(223, 194);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(89, 23);
            this.createButton.TabIndex = 4;
            this.createButton.Text = "Create Project";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.applyChangesButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 194);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // projectInfoGroupBox
            // 
            this.projectInfoGroupBox.Controls.Add(this.dateTimePicker);
            this.projectInfoGroupBox.Controls.Add(this.startDateLabel);
            this.projectInfoGroupBox.Controls.Add(this.shortDescLabel);
            this.projectInfoGroupBox.Controls.Add(this.shortDescTextBox);
            this.projectInfoGroupBox.Controls.Add(this.projectNameLabel);
            this.projectInfoGroupBox.Controls.Add(this.clientNameLabel);
            this.projectInfoGroupBox.Controls.Add(this.clientNameTextBox);
            this.projectInfoGroupBox.Controls.Add(this.projectNameTextBox);
            this.projectInfoGroupBox.Location = new System.Drawing.Point(12, 12);
            this.projectInfoGroupBox.Name = "projectInfoGroupBox";
            this.projectInfoGroupBox.Size = new System.Drawing.Size(300, 176);
            this.projectInfoGroupBox.TabIndex = 6;
            this.projectInfoGroupBox.TabStop = false;
            this.projectInfoGroupBox.Text = "Project Info:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(33, 126);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 8;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(39, 100);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(58, 13);
            this.startDateLabel.TabIndex = 7;
            this.startDateLabel.Text = "Start Date:";
            // 
            // shortDescLabel
            // 
            this.shortDescLabel.AutoSize = true;
            this.shortDescLabel.Location = new System.Drawing.Point(6, 72);
            this.shortDescLabel.Name = "shortDescLabel";
            this.shortDescLabel.Size = new System.Drawing.Size(91, 13);
            this.shortDescLabel.TabIndex = 6;
            this.shortDescLabel.Text = "Short Description:";
            // 
            // shortDescTextBox
            // 
            this.shortDescTextBox.Location = new System.Drawing.Point(103, 72);
            this.shortDescTextBox.Name = "shortDescTextBox";
            this.shortDescTextBox.Size = new System.Drawing.Size(130, 20);
            this.shortDescTextBox.TabIndex = 5;
            // 
            // projectScreenInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 233);
            this.Controls.Add(this.projectInfoGroupBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.createButton);
            this.Name = "projectScreenInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Project";
            this.Load += new System.EventHandler(this.projectScreenInputForm_Load);
            this.projectInfoGroupBox.ResumeLayout(false);
            this.projectInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox projectNameTextBox;
        private System.Windows.Forms.TextBox clientNameTextBox;
        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.Label clientNameLabel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.GroupBox projectInfoGroupBox;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label shortDescLabel;
        private System.Windows.Forms.TextBox shortDescTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}