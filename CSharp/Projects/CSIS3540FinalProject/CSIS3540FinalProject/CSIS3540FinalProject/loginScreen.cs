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
            newCustForm newCust = new newCustForm();
            this.Hide();
            newCust.Show();
        }

        private void returnCustBtn_Click(object sender, EventArgs e)
        {
            returnCustForm retCust = new returnCustForm();
            this.Hide();
            retCust.Show();
        }
    }
}
