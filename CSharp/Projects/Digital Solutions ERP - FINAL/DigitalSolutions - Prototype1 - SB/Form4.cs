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
    public partial class projectScreenForm : Form
    {
        //Declaring Queries object for later use.
        Queries getQ;

        public projectScreenForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //Resets index, and returns to either the Admin Main Screen or Employee Main Screen based on login information.
            this.Hide();
            DsUtil.selectedIndex = -1;
            if (loginScreenForm.username == "admin")
            {
                mainScreenFormAdmin mainScreenAdmin = new mainScreenFormAdmin();
                mainScreenAdmin.Show();
            }
            else
            {
                mainScreenFormEmployee mainScreenEmp = new mainScreenFormEmployee();
                mainScreenEmp.Show();
            }
        }

        
        private void createInvoiceButton_Click(object sender, EventArgs e)
        {
            //Launches the Create Invoice Screen
            createInvoiceForm createInvoice = new createInvoiceForm();
            createInvoice.Show();
            
        }

        private void applyChangesButton_Click(object sender, EventArgs e)
        {
            //Launches the "Edit Project" screen.
            DsUtil.formID = 1;
            projectScreenInputForm createEdit = new projectScreenInputForm();
            createEdit.Show();
        }

        private void projectScreenForm_Load(object sender, EventArgs e)
        {
            try
            {
                //Calculates the Hours Worked for a given project based off the sum of Hours to Complete for the tasks for
                //that project.
                int project = DsUtil.selectedIndex;
                getQ = new Queries(DsUtil.selectedIndex);
                RetrieveData update = new RetrieveData(getQ.getHoursWorkedQuery());
                bool flag = false;

                flag = update.updateData();

            }
            catch
            {
                MessageBox.Show("Hours computation failed.");
            }


            try
            {
                //Retrieves the same Project Info as listed on the Main Screen from the database and populates it on the
                //Project Screen
                int project = DsUtil.selectedIndex;
                getQ = new Queries(DsUtil.selectedIndex);

                pScreenDetailsListView.View = View.Details;
                RetrieveData rD = new RetrieveData(getQ.getEditProjectQueryOne());
                DataTable dataTable = rD.retrieveData();

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow dataRow = dataTable.Rows[i];

                    ListViewItem listData = new ListViewItem(dataRow["project_id"].ToString());
                    listData.SubItems.Add(dataRow["project_name"].ToString());
                    listData.SubItems.Add(dataRow["client_name"].ToString());
                    listData.SubItems.Add(dataRow["project_short_description"].ToString());
                    listData.SubItems.Add(dataRow["project_start_date"].ToString());

                    pScreenDetailsListView.Items.Add(listData);
                }
            }
            catch
            {
                MessageBox.Show("Database may have disconnected, or selected data is not available.");
            }

            try
            {
                //Retrieves and populates Assigned Employees and Materials fdor a given project.
                DsUtil utility = new DsUtil();
                int project = DsUtil.selectedIndex;
                getQ = new Queries(DsUtil.selectedIndex);

                pScreenEmpListView.View = View.Details;
                RetrieveData rD = new RetrieveData(getQ.getEditProjectQueryTwo());
                DataTable dataTable = rD.retrieveData();

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow dataRow = dataTable.Rows[i];

                    ListViewItem listData = new ListViewItem(utility.getEmployeeName((int)dataRow["employee_id"]));
                    listData.SubItems.Add(dataRow["hours_worked"].ToString());
                    listData.SubItems.Add(dataRow["material_name"].ToString());
                    listData.SubItems.Add(dataRow["material_price"].ToString());

                    pScreenEmpListView.Items.Add(listData);
                }
            }
            catch
            {
                MessageBox.Show("Assigned employees failed to load.");
            }

            try
            {
                //Retrieves and populates Task and related Employee information for a given project.
                DsUtil utility = new DsUtil();
                int project = DsUtil.selectedIndex;
                getQ = new Queries(DsUtil.selectedIndex);

                pScreenTaskListView.View = View.Details;
                RetrieveData rD2 = new RetrieveData(getQ.getEditProjectQueryThree());
                DataTable dataTable2 = rD2.retrieveData();

                for (int i = 0; i < dataTable2.Rows.Count; i++)
                {
                    DataRow dataRow = dataTable2.Rows[i];

                    ListViewItem listData = new ListViewItem(dataRow["task_description"].ToString());
                    listData.SubItems.Add(dataRow["task_hours_to_complete"].ToString());
                    listData.SubItems.Add(utility.getEmployeeName((int)dataRow["employee_id"]));

                    pScreenTaskListView.Items.Add(listData);
                }

            }
            catch
            {
                MessageBox.Show("Database may have disconnected, or selected data is not available.");
            }
        }

        private void newTaskButton_Click(object sender, EventArgs e)
        {
            //Launches the New Task Screen.
            newTaskForm newTask = new newTaskForm();
            newTask.Show();
        }
    }
}
