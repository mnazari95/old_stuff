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
    public partial class orderViewForm : Form
    {
        //Declaring variables for later use.
        List<Container> custContList;
        MySqlConnection connection;
        List<Item> itemList;
        Customer customer;
        int invoiceNum;

        public orderViewForm(List<Container> contList, Customer cust, int invNum)
        {
            //Setting up visuals for the user and prepping a database connection.
            InitializeComponent();
            custContList = contList;
            new DBConnect(out connection);
            customer = cust;
            this.Text = "Invoice Number: " + invNum;
            invoiceNum = invNum;
        }

        private void orderViewForm_Load(object sender, EventArgs e)
        {
            //Setting visuals for the DGV.
            orderView.ColumnCount = 3;
            orderView.Columns[0].Name = "Container ID:";
            orderView.Columns[1].Name = "Item Name:";
            orderView.Columns[2].Name = "Item Quantity:";

            //Load the DGV with info from the currently selected Invoice.
            for (int i = 0; i < custContList.Count(); i ++)
            {
                itemList = custContList[i].getItemList();
                orderView.Rows.Add(custContList[i].getID().ToString(), "", "");

                for(int j = 0; j < itemList.Count(); j++)
                {
                    orderView.Rows.Add("", itemList[j].getName(), itemList[j].getQuantity());
                }
            }

        }

        private void retrieveAllOfOneBtn_Click(object sender, EventArgs e)
        {
            //The "Retrieve All of One Item" button retrieves all of a user-selected Item from the Warehouse.

            MySqlCommand cmd = new MySqlCommand();
            DBQueries queries = new DBQueries();

            //If an invalid Item Name is selected, alert user and return to orderViewForm.
            if(orderView.SelectedCells[0].Value == null)
            {
                MessageBox.Show("Invalid Item Name selected, please select an Item Name and try again.");
                return;
            }

            string itemName = orderView.SelectedCells[0].Value.ToString();

            //If an invalid Item Name is selected, alert user and return to orderViewForm.
            if (orderView.Columns[orderView.CurrentCell.ColumnIndex].Name == orderView.Columns["Container ID:"].Name || orderView.Columns[orderView.CurrentCell.ColumnIndex].Name == orderView.Columns["Item Quantity:"].Name || itemName == "")
            {
                MessageBox.Show("Invalid Item Name selected, please select an Item Name and try again.");
                return;
            }

            //Get necessary Customer Info from database
            int itemID = queries.getItemID(connection, itemName);
            int contID = queries.getSingleContainerID(connection, itemID);
            int custID = customer.getID();

            //Retrieve all of specified Item from warehouse
            queries.retrieveAllOfOneItem(connection, itemID, custID, contID);


            //Refresh the DGV, displaying the newly updated Invoice with Item removed.
            custContList = queries.getCustStorageOrder(connection, custID);

            orderView.Rows.Clear();

            for (int i = 0; i < custContList.Count(); i++)
            {
                itemList = custContList[i].getItemList();
                orderView.Rows.Add(custContList[i].getID().ToString(), "", "");

                for (int j = 0; j < itemList.Count(); j++)
                {
                    orderView.Rows.Add("", itemList[j].getName(), itemList[j].getQuantity());
                }
            }

            //Alert user that Item has been retrieved successfully.
            MessageBox.Show("Item: " + itemName + " has been successfully retrieved.");
        }

        private void retrieveXBtn_Click(object sender, EventArgs e)
        {
            //The "Retrieve X Of One Item" button retrieves a specified quantity of a specific Item that the user has selected.

            MySqlCommand cmd = new MySqlCommand();
            DBQueries queries = new DBQueries();

            //If an invalid Item Name is selected, alert user and return to orderViewForm.
            if (orderView.SelectedCells[0].Value == null)
            {
                MessageBox.Show("Invalid Item Name selected, please select an Item Name and try again.");
                return;
            }

            string itemName = orderView.SelectedCells[0].Value.ToString();

            //If an invalid Item Name is selected, alert user and return to orderViewForm.
            if (orderView.Columns[orderView.CurrentCell.ColumnIndex].Name == orderView.Columns["Container ID:"].Name || orderView.Columns[orderView.CurrentCell.ColumnIndex].Name == orderView.Columns["Item Quantity:"].Name || itemName == "")
            {
                MessageBox.Show("Invalid Item Name selected, please select an Item Name and try again.");
                return;
            }

            //Get necessary info from database
            int curItemQuantity = queries.getItemQuantity(connection, itemName);
            int itemID = queries.getItemID(connection, itemName);
            string value = "";
            int numOfItems;


            //Prompt user to enter the quantity of Items they wish to retrieve.
            if (Dialog.InputBox("Enter the number of Items you would like to retrieve:", "Number of Items:", ref value) == DialogResult.OK)
            {
                numOfItems = int.Parse(value);

                int newQty = curItemQuantity - numOfItems;

                //If the user-entered quantity is larger than that remaining in the warehouse, alert user and return to orderViewForm
                if(newQty < 0)
                {
                    MessageBox.Show("Not enough quantity remaining to retrieve " + numOfItems + " of Item: " + itemName + ", please enter a quantity less than " + curItemQuantity);
                    return;
                }

                //Update quantity in the database.
                queries.retrieveXOfOneItem(connection, newQty, itemID);

                custContList = queries.getCustStorageOrder(connection, customer.getID());

                //Refresh the DGV, displaying the newly updated Invoice with Item quantity updated.
                orderView.Rows.Clear();

                for (int i = 0; i < custContList.Count(); i++)
                {
                    itemList = custContList[i].getItemList();
                    orderView.Rows.Add(custContList[i].getID().ToString(), "", "");

                    for (int j = 0; j < itemList.Count(); j++)
                    {
                        orderView.Rows.Add("", itemList[j].getName(), itemList[j].getQuantity());
                    }
                }

                //Alert the user that the quantity they have requested has been retrieved.
                MessageBox.Show("Quantity: " + numOfItems.ToString() + " of Item: " + itemName + " successfully retrieved.");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            //The "Back" button takes the user back to the Main Customer Portal screen.

            mainCustScreen mainScreen = new mainCustScreen(customer); 
            mainScreen.Show();
            this.Hide();
        }

        private void retrieveInvoiceBtn_Click(object sender, EventArgs e)
        {
            //The "Retrieve Entire Invoice" button allows the user to retrieve all Items under the selected Invoice.

            MySqlCommand cmd = new MySqlCommand();
            DBQueries queries = new DBQueries();
            List<string> itemNames = new List<string>();
            List<int> itemIDS = new List<int>();
            int invNum = invoiceNum;

            custContList = queries.getCustStorageOrder(connection, customer.getID());

            //Check to ensure that there is an Invoice to retrieve.
            if(custContList.Count <= 0)
            {
                MessageBox.Show("No Invoices to retrieve!");
                return;
            }

            //If there is an Invoice, retrieve all Items from it.
            for (int i = 0; i < custContList.Count; i++)
            {
                queries.retrieveEntireInvoice(connection, custContList[i].getID());
            }

            //Once Items have been retrieved, delete the associated Invoice data from the database.
            queries.deleteInvoice(connection, invNum, customer.getID());

            //Clear the DGV as the Invoice has now been deleted.
            orderView.Rows.Clear();

            //Alert user that all Items have been successfully retrieved.
            MessageBox.Show("All items under Invoice Number: " + invoiceNum + " have been successfully retrieved!");
        }
    }
}
