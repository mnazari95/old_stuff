using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSIS3540FinalProject
{
    public partial class mainCustScreen : Form
    {
        Customer customer;
        List<Container> contList;
        MySqlConnection connection;


        public mainCustScreen(Customer cust, List<Container> cntList)
        {
            InitializeComponent();
            customer = cust;
            contList = cntList;
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            //db 
            new DBConnect(out connection);

            MessageBox.Show(customer.ToString());
            
            for(int i = 0; i < contList.Count(); i++)
            {
                MessageBox.Show(contList[i].ToString());
            }
        }
    }
}
