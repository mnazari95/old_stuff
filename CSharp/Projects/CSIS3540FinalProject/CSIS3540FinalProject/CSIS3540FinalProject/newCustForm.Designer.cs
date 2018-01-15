namespace CSIS3540FinalProject
{
    partial class newCustForm
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
            this.fNameLabel = new System.Windows.Forms.Label();
            this.lNameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.companyLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.fNameText = new System.Windows.Forms.TextBox();
            this.companyText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.lNameText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Location = new System.Drawing.Point(12, 9);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(60, 13);
            this.fNameLabel.TabIndex = 0;
            this.fNameLabel.Text = "First Name:";
            // 
            // lNameLabel
            // 
            this.lNameLabel.AutoSize = true;
            this.lNameLabel.Location = new System.Drawing.Point(12, 35);
            this.lNameLabel.Name = "lNameLabel";
            this.lNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lNameLabel.TabIndex = 1;
            this.lNameLabel.Text = "Last Name:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(12, 139);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(48, 13);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.Text = "Address:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(12, 61);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(41, 13);
            this.phoneLabel.TabIndex = 3;
            this.phoneLabel.Text = "Phone:";
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Location = new System.Drawing.Point(12, 113);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(54, 13);
            this.companyLabel.TabIndex = 4;
            this.companyLabel.Text = "Company:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(12, 87);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(38, 13);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "E-mail:";
            // 
            // fNameText
            // 
            this.fNameText.Location = new System.Drawing.Point(78, 6);
            this.fNameText.Name = "fNameText";
            this.fNameText.Size = new System.Drawing.Size(194, 20);
            this.fNameText.TabIndex = 6;
            // 
            // companyText
            // 
            this.companyText.Location = new System.Drawing.Point(78, 110);
            this.companyText.Name = "companyText";
            this.companyText.Size = new System.Drawing.Size(194, 20);
            this.companyText.TabIndex = 7;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(78, 84);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(194, 20);
            this.emailText.TabIndex = 8;
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(78, 136);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(194, 20);
            this.addressText.TabIndex = 9;
            // 
            // lNameText
            // 
            this.lNameText.Location = new System.Drawing.Point(79, 32);
            this.lNameText.Name = "lNameText";
            this.lNameText.Size = new System.Drawing.Size(194, 20);
            this.lNameText.TabIndex = 10;
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(78, 58);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(194, 20);
            this.phoneText.TabIndex = 11;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(197, 162);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 36);
            this.clearBtn.TabIndex = 12;
            this.clearBtn.Text = "Clear Form";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(12, 162);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 36);
            this.submitBtn.TabIndex = 13;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // newCustForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 207);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.lNameText);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.companyText);
            this.Controls.Add(this.fNameText);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.lNameLabel);
            this.Controls.Add(this.fNameLabel);
            this.Name = "newCustForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.Label lNameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox fNameText;
        private System.Windows.Forms.TextBox companyText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.TextBox lNameText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button submitBtn;
    }
}