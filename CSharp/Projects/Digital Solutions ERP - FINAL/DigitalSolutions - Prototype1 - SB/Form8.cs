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
    public partial class newTaskForm : Form
    {
        public newTaskForm()
        {
            InitializeComponent();
        }

        private void enterTaskButton_Click(object sender, EventArgs e)
        {
            DsUtil utility = new DsUtil();

            //Set variables to user input
            int project = DsUtil.selectedIndex;
            string taskDesc = taskNameTextBox.Text;
            int hours = int.Parse(hoursTextBox.Text);
            int completedBy = utility.getEmployeeId(completedTextBox.Text);
            int materialID = utility.getMaterialId(materialNameTextBox.Text);
            bool flag = false;


                try
                {
                //Create SQL query.
                    string query = "INSERT INTO software_eng_db_1.task (task_description, task_hours_to_complete, employee_id, project_id, material_id)"
                                   + " VALUES('"+ taskDesc + "', " + hours + ", " + completedBy + ", " + project + ", " + materialID + ");";
                    //Send query to data retrieval class.
                    RetrieveData rD = new RetrieveData(query);
                    if (rD.updateData())
                    {
                    //If update is successful, set flag.
                        flag = true;
                    }

                    if (flag)
                    {
                        MessageBox.Show("New Task created.");
                    }
                }
                catch
                {
                    MessageBox.Show("Database may have disconnected, or selected data is not available.");
                }
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //Return to the previous screen.
            this.Hide();
        }
    }
}
