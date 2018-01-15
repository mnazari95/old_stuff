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
    public partial class newCustForm : Form
    {
        //Initializing List variables for later use
        List<Container> contList = new List<Container>();
        List<Item> itemList = new List<Item>();

        public newCustForm()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            //Validation tree for user input - checks to ensure all fields are filled out. If a field is left blank,
            //inform the user and return Focus to the blank field.
            if (fNameText.Text == null || fNameText.Text == "")
            {
                MessageBox.Show("Missing First Name, please fill in.");
                fNameText.Focus();
                return;
            }

            if (lNameText.Text == null || lNameText.Text == "")
            {
                MessageBox.Show("Missing Last Name, please fill in.");
                lNameText.Focus();
                return;
            }

            if (phoneText.Text == null || phoneText.Text == "")
            {
                MessageBox.Show("Missing Phone Number, please fill in.");
                phoneText.Focus();
                return;
            }

            if (emailText.Text == null || emailText.Text == "")
            {
                MessageBox.Show("Missing Email Address, please fill in.");
                emailText.Focus();
                return;
            }

            if (companyText.Text == null || companyText.Text == "")
            {
                MessageBox.Show("Missing Company Name, please fill in.");
                companyText.Focus();
                return;
            }

            if (addressText.Text == null || addressText.Text == "")
            {
                MessageBox.Show("Missing Company Address, please fill in.");
                addressText.Focus();
                return;
            }

            //Assuming all required fields are filled in, create a Customer object based on user input.
            Customer customer = new Customer(fNameText.Text, lNameText.Text, phoneText.Text, emailText.Text, companyText.Text, addressText.Text);

            //Variables for use with Dialog Box
            string value = "";
            int numOfItems;

            //If user presses OK for Dialog box...
            if (Dialog.InputBox("Enter the number of Containers you would like to store:", "Number of Containers:", ref value) == DialogResult.OK)
            {
                //...Parse the number of Containers they would like to enter...
                numOfItems = int.Parse(value);

                //...And pass all applicable information to the next form.
                newCustItemForm itemForm = new newCustItemForm(numOfItems, contList, itemList, customer);
                itemForm.Show();
                this.Close();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            //The "Clear" button clears all textboxes on the form.
            fNameText.Text = "";
            lNameText.Text = "";
            phoneText.Text = "";
            emailText.Text = "";
            companyText.Text = "";
            addressText.Text = "";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            //The "Back" button will take you back to the login screen.
            loginScreen login = new loginScreen();
            login.Show();
            this.Close();
        }
    }
}
