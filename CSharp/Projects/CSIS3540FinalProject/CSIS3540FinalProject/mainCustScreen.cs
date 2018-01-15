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
        //Initializing variables for later use.
        Customer customer;
        List<Container> contList;
        MySqlConnection connection;
        List<Item> itemList;
        List<int> custInvNums;
        bool isReturningCustomer;


        public mainCustScreen(Customer cust, List<Container> cntList, List<Item> itmList)
        {
            //Constructor for the mainCustScreen Form. Assigns values from the previous Form, and sets the 
            //greeting label for the current user.
            InitializeComponent();
            customer = cust;
            contList = cntList;
            itemList = itmList;
        }

        public mainCustScreen(Customer cust)
        {
            InitializeComponent();
            customer = cust;
            isReturningCustomer = true;
        }

        private void mainCustScreen_Load(object sender, EventArgs e)
        {
            //Variables for DB Connection, querying, and passing information between methods.
            greetingLabel.Text = "Hello " + customer.getName() + ", please select an option below:";
            double orderTotal = 0;
            new DBConnect(out connection);
            DBQueries queries = new DBQueries();
            List<int> containerIDList = new List<int>();

            if (!isReturningCustomer)
            {
                int invNum;
                //This set of queries inserts a new customer.
                queries.insertNewCustomer(customer, connection);
                customer = queries.getCustomer(connection, customer.getFName(), customer.getLName());

                //Retrieves invoice number for newly created invoice.
                invNum = queries.createInvoice(connection, customer.getID(), contList);

                //Inserts Container objects created on previous Forms into the Database
                queries.insertContainers(connection, contList, customer.getID(), invNum);
                containerIDList = (queries.getContainerID(connection, customer.getID()));

                //Inserts Item objects created on previous Forms into the Database
                queries.insertItems(connection, itemList, containerIDList);



            }
            else //handle returning customer
            {
                /* TO DO */   
                
            }

            //Retrieve the  current customers Storage Orders
            contList = queries.getCustStorageOrder(connection, customer.getID());

            //Calculate the total dollar amount for the Customers Storage Orders
            for(int i = 0; i < contList.Count; i++)
            {
                orderTotal += contList[i].getPrice();
            }

            //Display amount owing.
            curTotalLabel.Text += "$" + orderTotal;

            //Get Invoice Numbers for current Customer
            custInvNums = new List<int>();
            custInvNums = queries.getCustInvoices(connection, customer.getID());

            //Set visual for DataGridView
            mainScreenView.ColumnCount = 1;
            mainScreenView.Columns[0].Name = "Invoice Number:";

            //Display info to user.
            for(int i = 0; i < custInvNums.Count(); i++)
            {
                mainScreenView.Rows.Add(custInvNums[i].ToString());
            }

            mainScreenView.AutoResizeColumns();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //The "Exit" button exits the application.
            Application.Exit();
        }

        private void viewOrderBtn_Click(object sender, EventArgs e)
        {
            //The "View Order" button first checks to enusre that the customer has an Invoice to display. If they do, it 
            //queries the database to get all of the Containers associated with the Invoice Number, and then displays
            //the Containers and the Items within them in a new Form to the user.

            new DBConnect(out connection);
            DBQueries queries = new DBQueries();
            List<Container> containerList = queries.getCustStorageOrder(connection, customer.getID());

            //If no Invoices, alert user and return to Main Screen.
            if(containerList.Count <= 0)
            {
                MessageBox.Show("No Invoices to show!");
                return;
            }

            int invNum = containerList[0].getInvoiceNumber();

            //Pass all applicable info to the orderViewForm to be displayed to the user.
            orderViewForm orderView = new orderViewForm(containerList, customer, invNum);
            orderView.Show();
            this.Hide();

        }

        private void createNewOrderBtn_Click(object sender, EventArgs e)
        {
            List<Container> conList = new List<Container>();
            List<Item> itemList = new List<Item>();

            //Variables for use with Dialog Box
            string value = "";
            int numOfItems;

            //If user presses OK for Dialog box...
            if (Dialog.InputBox("Enter the number of Containers you would like to store:", "Number of Containers:", ref value) == DialogResult.OK)
            {
                //...Parse the number of Containers they would like to enter...
                numOfItems = int.Parse(value);

                newCustItemForm newCust = new newCustItemForm(numOfItems, conList, itemList, customer);
                newCust.Show();
                this.Hide();
            }
        }
    }
}
