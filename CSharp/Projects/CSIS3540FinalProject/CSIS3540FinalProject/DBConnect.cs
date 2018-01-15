using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSIS3540FinalProject
{
    /*
        DBConnect is a class used for connecting to the online Database we are using for our back-end. DBConnect attempts
        to connect to the Database, and if it is successful returns a MySqlConnection object. If it is unsuccessful the program
        informs the user it is unable to connect to the Database, and re-tries the connection up to a maximum of 5 times.
    */

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

            //Logic adapted from: http://stackoverflow.com/questions/8062867/retries-in-catch-block
            for (int attempts = 0; attempts < 5; attempts++)
            {
                try
                {
                    connection.Open();
                    break;
                }
                catch
                {
                    MessageBox.Show("Database Connection Attempt: " + (attempts + 1) + " failed, retrying...");
                }
                Thread.Sleep(50);
            }
            
        }
    }
}
