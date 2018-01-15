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
    public partial class createEmployeeForm : Form
    {
        public createEmployeeForm()
        {
            InitializeComponent();
        }

        private void createEmployeeButton_Click(object sender, EventArgs e)
        {
            //Set variables to user input.
            int addressID = 0;
            int wageID = 0;
            string fullName = fullNameTextBox.Text;
            string jobTitle = jobTitleTextBox.Text;
            string skill = skillTextBox.Text;
            int trueCheck = 1;

            //Check for full-time status
            if(fullTimeCheckBox.Checked == true)
            {
                trueCheck = 1;
            }
            else
            {
                trueCheck = 0;
            }

            //If the required textboxes are not blank...
            if(fullName != "" && jobTitle != "" && skill != "")
            {
                try
                {
                    RetrieveData rD = new RetrieveData();
                    //...Attempt to create the new employee.
                    if(rD.insertEmployee(fullName, trueCheck, skill, addressID, wageID, jobTitle))
                    {
                        //If successful, display message.
                        MessageBox.Show("Successfully created Employee.");
                    }
                    else
                    {
                        //If unsuccessful, also display message.
                        MessageBox.Show("Failed to create Employee.");
                    }
                }
                catch
                {

                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //Returns to the previous screen.
            this.Close();
            employeeListingForm employeeListing = new employeeListingForm();
            employeeListing.Show();
        }
    }
}
