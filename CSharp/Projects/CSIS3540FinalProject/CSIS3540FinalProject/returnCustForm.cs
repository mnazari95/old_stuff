using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSIS3540FinalProject
{
    public partial class returnCustForm : Form
    {
        MySqlConnection connection;
        //changed getCustomerID to getCustomer in DBQueries class
        //now it will return customer object instead of just customerID
        //overloaded customer constructor
        //overloaded mainscreen constructor

        public returnCustForm()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (!fNameText.Text.Equals("") || !lNameText.Text.Equals(""))
            {
                string firstName = fNameText.Text;
                string lastName = lNameText.Text;

                new DBConnect(out connection);
                DBQueries dbQ = new DBQueries();

                Customer cus = dbQ.getCustomer(connection, firstName, lastName);

                mainCustScreen mainScreen = new mainCustScreen(cus);
                mainScreen.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error: please fill out the fields with correct information.");
            }
            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            loginScreen login = new loginScreen();
            login.Show();
            this.Close();
        }
    }
}
