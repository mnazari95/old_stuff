using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace DigitalSolutions___Prototype1___SB
{
    public partial class mainScreenFormAdmin : Form
    {
        public mainScreenFormAdmin()
        {
            InitializeComponent();
        }

        private void createProjectButton_Click(object sender, EventArgs e)
        {
            //Launches the "Create Project" screen. dsUtil.formID is used to determine whether this screen should launch as 
            //"Create Project" or "Edit Project".
            DsUtil.formID = 0;
            projectScreenInputForm projectScreenInput = new projectScreenInputForm();
            projectScreenInput.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            //Secondary prompt to confirm logout
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //If the answer is yes, display message and return to login.
                MessageBox.Show("Logout Successful");
                this.Hide();
                loginScreenForm login = new loginScreenForm();
                login.Show();
            }
        }

       
        private void employeeListingButton_Click(object sender, EventArgs e)
        {
            //Launches the "Employee Listing" screen. Only visible to accounts with "Manager" level security.
            employeeListingForm employeeListing = new employeeListingForm();
            employeeListing.Show();
        }

        private void mainScreenFormAdmin_Load(object sender, EventArgs e)
        {
            //Load event for the Main Screen. getQ is a Queries object that is used to provide all of the SQL queries for the 
            //Main Screen.
            Queries getQ = new Queries();

            try {
                //Connecting to the database and retrieving data.
                mainScreenListView.View = View.Details;
                RetrieveData rD = new RetrieveData(getQ.getMainScreenQuery());

                //Call to retrieveData() actually sends query to database.
                DataTable dataTable = rD.retrieveData();
                
                //dataTable contains all of the information returned from the database. This for loop parses out that info
                //and loads it into a ListViewItem called listData. Information is assigned to the correct "field" so that when
                //the ListView is displayed it will show the info exactly as retrieved from the database.
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow dataRow = dataTable.Rows[i];

                    ListViewItem listData = new ListViewItem(dataRow["project_id"].ToString());
                    listData.SubItems.Add(dataRow["project_name"].ToString());
                    listData.SubItems.Add(dataRow["client_name"].ToString());
                    listData.SubItems.Add(dataRow["project_short_description"].ToString());
                    listData.SubItems.Add(dataRow["project_start_date"].ToString());

                    mainScreenListView.Items.Add(listData);
                }
            }
            catch
            {
                MessageBox.Show("Database may have disconnected, or selected data is not available.");
            }


        }

        private void editProjectButton_Click(object sender, EventArgs e)
        {

            //Launches the Project Screen for a given selected project.
            DsUtil dsU = new DsUtil();
            //Checks to see if a project is selected:
            if (dsU.getSelected(mainScreenListView) != -1)
            {
                //If it is, assign the correct index for the project and launch the Project Screen.
                int index = mainScreenListView.Items[dsU.getSelected(mainScreenListView)].Index;
                dsU.assignIndex(index);
                this.Hide();
                projectScreenForm projectScreen = new projectScreenForm();
                projectScreen.Show();
            }
            else
            {
                //If no project is selected, display an error message.
                MessageBox.Show("Please select a project to edit.", "Error");
            }
        }

        
    }
}
