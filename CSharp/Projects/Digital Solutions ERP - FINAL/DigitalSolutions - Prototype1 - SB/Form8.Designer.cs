namespace DigitalSolutions___Prototype1___SB
{
    partial class newTaskForm
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
            this.taskGroupBox = new System.Windows.Forms.GroupBox();
            this.completedTextBox = new System.Windows.Forms.TextBox();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.taskNameTextBox = new System.Windows.Forms.TextBox();
            this.completedByLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.taskNameLabel = new System.Windows.Forms.Label();
            this.enterTaskButton = new System.Windows.Forms.Button();
            this.materialsGroupBox = new System.Windows.Forms.GroupBox();
            this.materialNameTextBox = new System.Windows.Forms.TextBox();
            this.materialNameLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.taskGroupBox.SuspendLayout();
            this.materialsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskGroupBox
            // 
            this.taskGroupBox.Controls.Add(this.completedTextBox);
            this.taskGroupBox.Controls.Add(this.hoursTextBox);
            this.taskGroupBox.Controls.Add(this.taskNameTextBox);
            this.taskGroupBox.Controls.Add(this.completedByLabel);
            this.taskGroupBox.Controls.Add(this.hoursLabel);
            this.taskGroupBox.Controls.Add(this.taskNameLabel);
            this.taskGroupBox.Location = new System.Drawing.Point(12, 12);
            this.taskGroupBox.Name = "taskGroupBox";
            this.taskGroupBox.Size = new System.Drawing.Size(260, 100);
            this.taskGroupBox.TabIndex = 8;
            this.taskGroupBox.TabStop = false;
            this.taskGroupBox.Text = "New Task Info:";
            // 
            // completedTextBox
            // 
            this.completedTextBox.Location = new System.Drawing.Point(103, 63);
            this.completedTextBox.Name = "completedTextBox";
            this.completedTextBox.Size = new System.Drawing.Size(100, 20);
            this.completedTextBox.TabIndex = 5;
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Location = new System.Drawing.Point(103, 37);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(100, 20);
            this.hoursTextBox.TabIndex = 4;
            // 
            // taskNameTextBox
            // 
            this.taskNameTextBox.Location = new System.Drawing.Point(103, 11);
            this.taskNameTextBox.Name = "taskNameTextBox";
            this.taskNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.taskNameTextBox.TabIndex = 3;
            // 
            // completedByLabel
            // 
            this.completedByLabel.AutoSize = true;
            this.completedByLabel.Location = new System.Drawing.Point(22, 63);
            this.completedByLabel.Name = "completedByLabel";
            this.completedByLabel.Size = new System.Drawing.Size(75, 13);
            this.completedByLabel.TabIndex = 2;
            this.completedByLabel.Text = "Completed By:";
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(0, 37);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(97, 13);
            this.hoursLabel.TabIndex = 1;
            this.hoursLabel.Text = "Hours to Complete:";
            // 
            // taskNameLabel
            // 
            this.taskNameLabel.AutoSize = true;
            this.taskNameLabel.Location = new System.Drawing.Point(32, 18);
            this.taskNameLabel.Name = "taskNameLabel";
            this.taskNameLabel.Size = new System.Drawing.Size(65, 13);
            this.taskNameLabel.TabIndex = 0;
            this.taskNameLabel.Text = "Task Name:";
            // 
            // enterTaskButton
            // 
            this.enterTaskButton.Location = new System.Drawing.Point(197, 179);
            this.enterTaskButton.Name = "enterTaskButton";
            this.enterTaskButton.Size = new System.Drawing.Size(75, 23);
            this.enterTaskButton.TabIndex = 9;
            this.enterTaskButton.Text = "Enter Task";
            this.enterTaskButton.UseVisualStyleBackColor = true;
            this.enterTaskButton.Click += new System.EventHandler(this.enterTaskButton_Click);
            // 
            // materialsGroupBox
            // 
            this.materialsGroupBox.Controls.Add(this.materialNameTextBox);
            this.materialsGroupBox.Controls.Add(this.materialNameLabel);
            this.materialsGroupBox.Location = new System.Drawing.Point(15, 118);
            this.materialsGroupBox.Name = "materialsGroupBox";
            this.materialsGroupBox.Size = new System.Drawing.Size(260, 55);
            this.materialsGroupBox.TabIndex = 10;
            this.materialsGroupBox.TabStop = false;
            this.materialsGroupBox.Text = "New Materials Info:";
            // 
            // materialNameTextBox
            // 
            this.materialNameTextBox.Location = new System.Drawing.Point(103, 24);
            this.materialNameTextBox.Name = "materialNameTextBox";
            this.materialNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.materialNameTextBox.TabIndex = 2;
            // 
            // materialNameLabel
            // 
            this.materialNameLabel.AutoSize = true;
            this.materialNameLabel.Location = new System.Drawing.Point(19, 27);
            this.materialNameLabel.Name = "materialNameLabel";
            this.materialNameLabel.Size = new System.Drawing.Size(78, 13);
            this.materialNameLabel.TabIndex = 0;
            this.materialNameLabel.Text = "Material Name:";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 179);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // newTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 214);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.materialsGroupBox);
            this.Controls.Add(this.enterTaskButton);
            this.Controls.Add(this.taskGroupBox);
            this.Name = "newTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter New Task";
            this.taskGroupBox.ResumeLayout(false);
            this.taskGroupBox.PerformLayout();
            this.materialsGroupBox.ResumeLayout(false);
            this.materialsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox taskGroupBox;
        private System.Windows.Forms.TextBox completedTextBox;
        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.TextBox taskNameTextBox;
        private System.Windows.Forms.Label completedByLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label taskNameLabel;
        private System.Windows.Forms.Button enterTaskButton;
        private System.Windows.Forms.GroupBox materialsGroupBox;
        private System.Windows.Forms.TextBox materialNameTextBox;
        private System.Windows.Forms.Label materialNameLabel;
        private System.Windows.Forms.Button backButton;
    }
}