using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace DigitalSolutions___Prototype1___SB
{
    class DsUtil
    {
        //Static fields used for logic control.
        public static int selectedIndex = -1;
        public static int formID = -1;


        //Used to check which index of a ListView is selected.
        public int getSelected(ListView lV)
        {

            for (int i = 0; i < lV.Items.Count; i++)
            {
                if (lV.Items[i].Selected)
                {
                    return lV.Items[i].Index;
                }
            }
            return -1;
        }

        //Translates Employee ID's into Employee Names. Takes an ID, returns a Name.
        public string getEmployeeName(int employeeId)
        {
            string quary = "SELECT employee.employee_name FROM software_eng_db_1.employee " +
                "WHERE employee.employee_id = " + employeeId + ";";
            string employeeName = "";

            RetrieveData rD = new RetrieveData(quary);
            DataTable table = rD.retrieveData();
            if (table.Rows.Count == 0)
            {
                return employeeName = "No data returned, input invalid.";
            }
            else
            {
                DataRow dR = table.Rows[0];
                employeeName = dR["employee_name"].ToString();
                return employeeName;
            }
        }

        //Translates Employee Names into Employee ID's. Takes a Name, returns an ID.
        public int getEmployeeId(string employeeName)
        {
            string quary = "SELECT employee.employee_id FROM software_eng_db_1.employee " +
                "WHERE employee.employee_name = '" + employeeName + "';";
            int employeeID = -1;

            RetrieveData rD = new RetrieveData(quary);
            DataTable table = rD.retrieveData();
            if (table.Rows.Count == 0)
            {
                return employeeID;
            }
            else
            {
                DataRow dR = table.Rows[0];
                employeeID = int.Parse(dR["employee_id"].ToString());
                return employeeID;
            }
        }

        //Translates Material Names into Material ID's. Takes a Name, returns an ID.
        public int getMaterialId(string materialName)
        {
            string query = "SELECT material.material_id FROM software_eng_db_1.material "
                           + "WHERE material.material_name = '" + materialName + "';";

            int materialID = 0;

            RetrieveData rD = new RetrieveData(query);
            DataTable table = rD.retrieveData();
            if(table.Rows.Count == 0)
            {
                return materialID;
            }
            else
            {
                DataRow dR = table.Rows[0];
                materialID = int.Parse(dR["material_id"].ToString());
                return materialID;
            }
        }

        //Translates Client Names into Client ID's. Takes a name, returns an ID.
        public int getClientID(string clientName)
        {
            int clientID = 0;

            string query = "SELECT customer.client_id FROM software_eng_db_1.customer "
                           + "WHERE customer.client_name = '" + clientName + "';";

            RetrieveData rD = new RetrieveData(query);
            DataTable table = rD.retrieveData();
            if(table.Rows.Count == 0)
            {
                string empQuery = "INSERT INTO software_eng_db_1.customer(client_name, address_id) "
                                  + "VALUES('"+ clientName + "', 0);";

                RetrieveData update = new RetrieveData(empQuery);
                update.updateData();

                DataTable table2 = rD.retrieveData();
                DataRow dR2 = table2.Rows[0];
                clientID = int.Parse(dR2["client_id"].ToString());
                return clientID;

            }
            else
            {
                DataRow dR = table.Rows[0];
                clientID = int.Parse(dR["client_id"].ToString());
                return clientID;
            }

        }

        //Used for the "Select Project" button to both assign the correct index for the Item selected in the ListView,
        //but also to send the correct project code in the SQL query to the database. Needed because as projects are added,
        //deleted, and assigned other codes, the AUTO_INCREMENT setting on the Primary Key in the mySQL database does not 
        //update to reflect newly unassigned primary keys.
        public void assignIndex(int index)
        {
            string query = "SELECT project.project_id FROM software_eng_db_1.project;";

            RetrieveData utility = new RetrieveData(query);

            DataTable table = utility.retrieveData();

            string[] projArray;
            projArray = new string[table.Rows.Count];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                projArray[i] = row["project_id"].ToString();
            }

            for(int j = 0; j < table.Rows.Count; j++)
            {
                if(j == index)
                {
                    selectedIndex = int.Parse(projArray[j]);
                }
            }
        }
    }
}
