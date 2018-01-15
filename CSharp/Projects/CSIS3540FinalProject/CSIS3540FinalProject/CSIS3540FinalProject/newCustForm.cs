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
        List<Item> itemList = new List<Item>();
        List<Container> contList = new List<Container>();

        public newCustForm()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (fNameText.Text == null || fNameText.Text == "")
            {
                MessageBox.Show("Missing First Name, please fill in.");
                fNameText.Text = "***MISSING***";
                return;
            }

            if (lNameText.Text == null || lNameText.Text == "")
            {
                MessageBox.Show("Missing Last Name, please fill in.");
                lNameText.Text = "***MISSING***";
                return;
            }

            if (phoneText.Text == null || phoneText.Text == "")
            {
                MessageBox.Show("Missing Phone Number, please fill in.");
                phoneText.Text = "***MISSING***";
                return;
            }

            if (emailText.Text == null || emailText.Text == "")
            {
                MessageBox.Show("Missing Email Address, please fill in.");
                emailText.Text = "***MISSING***";
                return;
            }

            if (companyText.Text == null || companyText.Text == "")
            {
                MessageBox.Show("Missing Company Name, please fill in.");
                companyText.Text = "***MISSING***";
                return;
            }

            if (addressText.Text == null || addressText.Text == "")
            {
                MessageBox.Show("Missing Company Address, please fill in.");
                addressText.Text = "***MISSING***";
                return;
            }


            Customer customer = new Customer(fNameText.Text, lNameText.Text, phoneText.Text, emailText.Text, companyText.Text, addressText.Text);

            string value = "";
            int numOfItems;

            //If user presses OK for Dialog box...
            if (Dialog.InputBox("Enter the number of Items you would like to store:", "Number of Items:", ref value) == DialogResult.OK)
            {
                numOfItems = int.Parse(value);

                newCustItemForm itemForm = new newCustItemForm(numOfItems, itemList, contList, customer);
                this.Hide();
                itemForm.Show();
            }

            

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            fNameText.Text = "";
            lNameText.Text = "";
            phoneText.Text = "";
            emailText.Text = "";
            companyText.Text = "";
            addressText.Text = "";
        }
    }
}
