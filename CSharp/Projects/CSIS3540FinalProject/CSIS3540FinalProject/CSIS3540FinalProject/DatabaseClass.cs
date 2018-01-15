using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSIS3540FinalProject
{
    class DatabaseClass
    {
        private MySqlConnection mCon;

        public DatabaseClass(MySqlConnection mCon) {
            this.mCon = mCon;
        }

        public void insertData(string query) {
            MySqlCommand cmd = new MySqlCommand(query, mCon);
            //Execute command
            cmd.ExecuteNonQuery();
            //close connection
            mCon.Close();
        }

        public void updateData(string query) {
            MySqlCommand cmd = new MySqlCommand(query, mCon);
            cmd.ExecuteNonQuery();
            mCon.Close();
        }

        public void deleteData(string query) {
            MySqlCommand cmd = new MySqlCommand(query, mCon);
            cmd.ExecuteNonQuery();
            mCon.Close();
        }

        public void selectData(string query, DataGridView mView) {
            MySqlCommand cmd = new MySqlCommand(query, mCon);
            MySqlDataAdapter mcmd = new MySqlDataAdapter();

            mcmd.SelectCommand = cmd;
            DataSet ds = new DataSet();
            mcmd.Fill(ds);
            mView.DataSource = ds.Tables[0];
            mcmd.Dispose();
        }

    }
}
