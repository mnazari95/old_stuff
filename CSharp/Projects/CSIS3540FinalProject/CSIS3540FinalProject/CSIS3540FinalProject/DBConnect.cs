using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSIS3540FinalProject
{
    class DBConnect
    {
        //Fields
        string server = "ec2-52-201-212-193.compute-1.amazonaws.com";
        string database = "s2016_user27";
        string user = "s2016_user27";
        string pass = "s2016_user27";

        //Constructor
        public DBConnect(out MySqlConnection connection)
        {
            string connectionString = "server="+ server + ";" + "userid=" + user + ";" + "password=" + pass + ";" +"database=" + database + ";";

            connection = new MySqlConnection(connectionString);

            connection.Open();

            if(connection == null)
            {
                MessageBox.Show("Database connection failed, please contact Administrator.");
            }
            else
            {
                MessageBox.Show("DB Connection successful.");
            }
        }
    }
}
