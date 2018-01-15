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
    public partial class employeeListingForm : Form
    {
        public employeeListingForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //Returns to the previous screen.
            this.Hide();
        }

        private void employeeListingForm_Load(object sender, EventArgs e)
        {
            try
            {
                //Retrieves and populates Employee data from the database.
                string query = "SELECT employee.employee_name, employee.job_title, employee.employee_skills FROM employee";

                employeeListingListView.View = View.Details;
                RetrieveData rD = new RetrieveData(query);
                DataTable dataTable = rD.retrieveData();


                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow dataRow = dataTable.Rows[i];

                    ListViewItem listData = new ListViewItem(dataRow["employee_name"].ToString());
                    listData.SubItems.Add(dataRow["job_title"].ToString());
                    listData.SubItems.Add(dataRow["employee_skills"].ToString());

                    employeeListingListView.Items.Add(listData);
                }
            }
            catch
            {
                MessageBox.Show("Database may have disconnected, or selected data is not available.");
            }
        }

        private void deactivateEmployeeButton_Click(object sender, EventArgs e)
        {
            //Deactivates a selected employee.
            try
            {
                //Checks to ensure an employee is selected.
                if(employeeListingListView.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Employee not selected, select an Employee and try again.");
                }
                //Loops through and deletes only the selected employee.
                foreach(int i in employeeListingListView.SelectedIndices)
                {
                    DsUtil utility = new DsUtil();
                    int employee = utility.getEmployeeId(employeeListingListView.Items[i].Text);
                    employeeListingListView.Items.Remove(employeeListingListView.Items[i]);
                    string query = "DELETE FROM software_eng_db_1.employee WHERE employee.employee_id = " + employee + ";";

                    RetrieveData rD = new RetrieveData(query);
                    if(rD.updateData())
                    {
                        //Shows a success message upon sucessful deletion from the database.
                        MessageBox.Show("Employee Deactivated.");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Database may have disconnected, or selected data is not available.");
            }
        }

        private void createEmployeeButton_Click(object sender, EventArgs e)
        {
            //Launches the Create Employee Screen.
            createEmployeeForm createEmp = new createEmployeeForm();
            createEmp.Show();
            this.Hide();
        }
    }
}
