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
    public partial class loginScreen : Form
    {
        public loginScreen()
        {
            InitializeComponent();
        }

        private void newCustBtn_Click(object sender, EventArgs e)
        {
            //If the user presses "New Customer", launch the New Customer Form
            newCustForm newCust = new newCustForm();
            newCust.Show();
            this.Hide();
        }

        private void returnCustBtn_Click(object sender, EventArgs e)
        {
            //If the user presses "Returning Customer", launch the Returning Customer Form
            returnCustForm retCust = new returnCustForm();
            retCust.Show();
            this.Hide();
        }
    }
}
