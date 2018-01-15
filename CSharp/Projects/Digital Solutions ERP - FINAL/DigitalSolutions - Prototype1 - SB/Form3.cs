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
    public partial class projectScreenInputForm : Form
    {
        //Declaring an object for use later
        ProjectHandler handler;

        public projectScreenInputForm()
        {
            InitializeComponent();
        }

        private void applyChangesButton_Click(object sender, EventArgs e)
        {
            //This button is used for two different things depending on the context in which it is clicked. The "handler" variable
            //is responsible for providing context as to whether this screen is creating or editing a project. Once clicked, the 
            //buton methods will either create a new project or edit an existing one based on the current setting in the ProjectHandler.cs
            //class.
            DsUtil utility = new DsUtil();
            handler = new ProjectHandler(DsUtil.formID);

            int project = DsUtil.selectedIndex;
            string projectName = projectNameTextBox.Text;
            int clientID = utility.getClientID(clientNameTextBox.Text);
            string shortDesc = shortDescTextBox.Text;
            DateTime date = dateTimePicker.Value;

            bool flag = false;
            bool flag1 = false;


            if(projectName != "" && clientID != 0 && shortDesc != "")
            {
                if (handler.getID() == 0)
                {
                    //Create Project
                    RetrieveData update = new RetrieveData();
                    flag = update.createProject(projectName, shortDesc, date, clientID);
                }
                else
                {
                    //Edit Project
                    RetrieveData edit = new RetrieveData();
                    flag1 = edit.editProject(projectName, shortDesc, date, clientID);
                }
                if(flag)
                {
                    MessageBox.Show("Project created successfully.");
                }

                if(flag1)
                {
                    MessageBox.Show("Project edited successfully.");
                }
            }
            else
            {
                MessageBox.Show("Data missing, please ensure you have filled out all required fields.");
            }


        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //Resets the index, returns to previous page.
            DsUtil.selectedIndex = -1;
            DsUtil.formID = -1;
            this.Hide();
        }

        private void projectScreenInputForm_Load(object sender, EventArgs e)
        {
            //Loads either "Create Project" or "Edit Project" based on context from ProjectHandler.cs
            ProjectHandler handler = new ProjectHandler(DsUtil.formID);
            this.Text = handler.getTitle();
            createButton.Text = handler.getButton();
        }
    }
}
