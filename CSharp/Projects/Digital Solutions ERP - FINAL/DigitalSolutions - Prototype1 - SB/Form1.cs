using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalSolutions___Prototype1___SB
{
    public partial class loginScreenForm : Form
    {
        public static string username;

        public loginScreenForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //"Login System" with simple validation.
            if (usernameTextBox.Text == "admin" && passwordTextBox.Text == "12345")
            {
                username = "admin";
                mainScreenFormAdmin mainScreenAdmin = new mainScreenFormAdmin();
                mainScreenAdmin.Show();
                this.Hide();
            }
            else if (usernameTextBox.Text == "employee" && passwordTextBox.Text == "12345")
            {
                username = "employee";
                mainScreenFormEmployee mainScreenEmployee = new mainScreenFormEmployee();
                mainScreenEmployee.Show();
                this.Hide();
            }
            else 
            {
                errorLabel.Text = "Incorrect login information provided.";
            }
        }
        
        //Exits the program.
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
