using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace DigitalSolutions___Prototype1___SB
{
    class RetrieveData
    {
        //fields
        private string connectionString = "server=localhost;userid=root;password=root;persistsecurityinfo=True;database=software_eng_db_1";
        private MySqlConnection connection;
        private MySqlDataAdapter dbAdapter;
        private string quary;

        //constructor
        public RetrieveData(string quary)
        {
            this.quary = quary;
            connection = new MySqlConnection(connectionString);
        }

        //constructor
        public RetrieveData()
        {
            connection = new MySqlConnection(connectionString);
        }

        //This method will get data from the Database requested by a given SQL query. Returns a dataset returnes from the SQL query
        //on success, and returns FALSE on failure.
        public DataTable retrieveData()
        {

            DataTable dt = new DataTable();
            dbAdapter = new MySqlDataAdapter(quary, connection);
            try
            {
                connection.Open();
                dbAdapter.Fill(dt);
            }
            catch (MySqlException mse) { MessageBox.Show(mse.Message);}
            connection.Close();

            return dt;
        }

        //This method will update data in the Database using a given SQL query. Returns TRUE on success and FALSE on failure.
        public Boolean updateData()
        {
            bool flag = false;
            try
            {
                MySqlCommand myCmd = new MySqlCommand(quary, connection);
                MySqlDataReader myReader;
                connection.Open();
                myReader = myCmd.ExecuteReader();
                flag = true;
                connection.Close();
            }
            catch(MySqlException mse) { MessageBox.Show(mse.Message);}

            return flag;
        }

        //Thsi method is specifically for inserting employees into the database. It takes all of the required info for an employee,
        //and returns TRUE when it successfully updates the database. Returns FALSE on database update failure.
        public Boolean insertEmployee(string name, int condition, string skills, int address, int wage, string title)
        {
            bool flag = false;

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO software_eng_db_1.employee(employee_name, employee_is_full_time, employee_skills, address_id, wage_id, job_title) "
                                                  + "VALUES('" + name + "', " + condition + ", '" + skills + "', " + address + ", " + wage + ", '" + title + "');", connection);
                cmd.ExecuteNonQuery();
                flag = true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connection.Close();

            return flag;
        }

        //Specific method for creating a new preoject in the database. Takes all of the required info for a new project, and returns
        //TRUE when it successfully updates the database. Returns FALSE on database update failure.
        public Boolean createProject(string projectName, string shortDesc, DateTime date, int clientID)
        {
            bool flag = false;

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO software_eng_db_1.project(project_name, project_short_description, project_start_date, client_id) "
                                + "VALUES('" + projectName + "' , '" + shortDesc + "' , '" + date + "' , '" + clientID + "');", connection);
                cmd.ExecuteNonQuery();
                flag = true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connection.Close();

            return flag;
        }

        //Specific method for editing projects already created in the database. Returns TRUE on a successful update, and FALSE 
        //on update failure.
        public Boolean editProject(string projectName, string shortDesc, DateTime date, int clientID)
        {
            bool flag = false;

            try
            {
                connection.Open();

                if (projectName != "")
                {

                    MySqlCommand cmd1 = new MySqlCommand("UPDATE software_eng_db_1.project"
                                                        + " SET project_name = " + "'" + projectName + "'"
                                                        + " WHERE project_id = " + DsUtil.selectedIndex + ";", connection);
                    cmd1.ExecuteNonQuery();
                    flag = true;
                }

                if (shortDesc != "")
                {

                    MySqlCommand cmd2 = new MySqlCommand("UPDATE software_eng_db_1.project"
                                                        + " SET project_short_description = " + "'" + shortDesc + "'"
                                                        + " WHERE project_id = " + DsUtil.selectedIndex + ";", connection);
                    cmd2.ExecuteNonQuery();
                    flag = true;
                }

                if(clientID != 0)
                {

                    MySqlCommand cmd3 = new MySqlCommand("UPDATE software_eng_db_1.project"
                                                        + " SET client_id = " + clientID
                                                        + " WHERE project_id = " + DsUtil.selectedIndex + ";", connection);
                    cmd3.ExecuteNonQuery();
                    flag = true;
                }


                MySqlCommand cmd = new MySqlCommand("UPDATE project"
                                                    + " SET project_start_date = " + "'" + date + "'"
                                                    + " WHERE project_id = " + DsUtil.selectedIndex + ";", connection);
                cmd.ExecuteNonQuery();


            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connection.Close();

            return flag;
        }

    }
}
