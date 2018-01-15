using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DigitalSolutions___Prototype1___SB
{
    public partial class createInvoiceForm : Form
    {
        public createInvoiceForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //Returns to the previous screen.
            this.Hide();
        }

        private void viewInvoiceButton_Click(object sender, EventArgs e)
        {
            //Starts the default PDF viewer on the host computer to view the .PDF stored at the specified filepath.
            Process.Start("H:\\CSIS 3275 - Software Engineering\\Digital Solutions Files\\Project Proposal\\Invoice.pdf");
        }

        private void printInvoiceButton_Click(object sender, EventArgs e)
        {
            //Fake "Print Command" as proof of concept.
            MessageBox.Show("Print Command sent.");
        }
    }
}
