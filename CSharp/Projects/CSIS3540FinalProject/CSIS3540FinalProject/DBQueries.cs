using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSIS3540FinalProject
{
    /*
        DBQueries is a class used to hold all of our MySQL queries and associated Database activities. Each query is named for
        the function it performs.
    */


    class DBQueries
    {
        //Fields


        //Constructor

        //Methods
        public void insertNewCustomer(Customer cust, MySqlConnection connection)
        {
            MySqlCommand cmd = new MySqlCommand();
            string query = "INSERT INTO customer(customerFName, customerLName, customerPhone, customerEmail, customerCompany, CustomerAddress) "
                           + "VALUES('" + cust.getFName() + "', '" + cust.getLName() + "', '" + cust.getPhone() + "', '" + cust.getEmail() + "', '" + cust.getCompany() + "', '" + cust.getAddress() + "');";

            cmd.Connection = connection;
            cmd.CommandText = query;

            cmd.ExecuteNonQuery();
        }

        public Customer getCustomer(MySqlConnection connection, string fname, string lname)
        {
            int custID;
            string custFName, custLName, custPhone, custEmail, custCompany, custAddress;

            MySqlCommand cmd = new MySqlCommand();
            string query = "SELECT * FROM customer "
                           + "WHERE customerFName = '" + fname + "' AND customerLName = '" + lname + "';";

            cmd.Connection = connection;
            cmd.CommandText = query;

            MySqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            custID = int.Parse(reader["customerID"].ToString());
            custFName = reader["customerFName"].ToString();
            custLName = reader["customerLName"].ToString();
            custPhone = reader["customerPhone"].ToString();
            custEmail = reader["customerEmail"].ToString();
            custCompany = reader["customerCompany"].ToString();
            custAddress = reader["customerAddress"].ToString();

            reader.Close();

            return new Customer(custID, custFName, custLName, custPhone, custEmail, custCompany, custAddress);
        }

        public int getItemID(MySqlConnection connection, string itemName)
        {
            int itemID;
            MySqlCommand cmd = new MySqlCommand();
            string query = "SELECT itemID FROM items "
                           + "WHERE itemName = '" + itemName + "';";

            cmd.Connection = connection;
            cmd.CommandText = query;

            MySqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            itemID = int.Parse(reader["itemID"].ToString());

            reader.Close();

            return itemID;
        }

        public List<int> getContainerID(MySqlConnection connection, int custID)
        {
            List<int> contID = new List<int>();
            MySqlCommand cmd = new MySqlCommand();
            string query = "SELECT containerID FROM containers WHERE customerID = " + custID + ";";

            cmd.Connection = connection;
            cmd.CommandText = query;

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                contID.Add(int.Parse(reader["containerID"].ToString()));
            }

            reader.Close();

            return contID;
        }

        public int getSingleContainerID(MySqlConnection connection, int itemID)
        {
            int containerID;
            MySqlCommand cmd = new MySqlCommand();
            string query = "SELECT containerID FROM items WHERE itemID = " + itemID + ";";

            cmd.Connection = connection;
            cmd.CommandText = query;

            MySqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            containerID = int.Parse(reader["containerID"].ToString());

            reader.Close();

            return containerID;
        }

        public List<Container> getCustStorageOrder(MySqlConnection connection, int custID)
        {
            List<Container> custOrderList = new List<Container>();
            MySqlCommand cmd = new MySqlCommand();
            string query = "SELECT * FROM containers WHERE customerID = " + custID + ";";

            cmd.Connection = connection;
            cmd.CommandText = query;

            MySqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                Container container = new Container(double.Parse(reader["containerWidth"].ToString()), double.Parse(reader["containerLength"].ToString()), double.Parse(reader["containerHeight"].ToString()));
                container.setID(int.Parse(reader["containerID"].ToString()));
                container.setInvoiceNumber(int.Parse(reader["invoiceID"].ToString()));
                custOrderList.Add(container);
            }

            reader.Close();

            for (int i = 0; i < custOrderList.Count(); i++)
            {
                query = "SELECT * FROM items WHERE containerID = " + custOrderList[i].getID();

                cmd.Connection = connection;
                cmd.CommandText = query;

                reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    Item item = new Item(reader["itemName"].ToString(), int.Parse(reader["itemQuantity"].ToString()), double.Parse(reader["itemWeight"].ToString()));
                    custOrderList[i].addItem(item);
                }

                reader.Close();
            }

            return custOrderList;
        }

        public void insertContainers(MySqlConnection connection, List<Container> contList, int custID, int invNum)
        {
            MySqlCommand cmd = new MySqlCommand();

            /*
                SHELF SPACE ALGORITHM - RETURNS LOCCODE
            */
            string availableLocation = getShelfData(connection); 
            /*
                END OF ALGORITHM
            */

            for (int i = 0; i < contList.Count(); i++)
            {
                string query = "INSERT INTO containers (customerID, invoiceID, containerWidth, containerLength, containerHeight, containerVolume, "
                               + "containerWeight, containerQuantity, containerStorageDate, shelfID) "
                               + "VALUES(" + custID + ", "+ invNum + ", " + contList[i].getWidth() + ", " + contList[i].getLength() + ", " + contList[i].getHeight()
                               + ", " + contList[i].getVolume() + ", " + contList[i].getWeight() + ", " + contList[i].getQuantity()
                               + ", " + "'" + contList[i].getStoreDate() + "', '" + "A1-S1-1" + "');";

                cmd.Connection = connection;
                cmd.CommandText = query;

                cmd.ExecuteNonQuery();
            }
        }

        private Dictionary<string, int> getShelfData(MySqlConnection connection, )
        {


            throw new NotImplementedException();
        }

        public void insertItems(MySqlConnection connection, List<Item> itemList, List<int> contIDList)
        {
            MySqlCommand cmd = new MySqlCommand();

            for(int i = 0; i < itemList.Count(); i++)
            {
                string query = "INSERT INTO items (itemName, itemWeight, itemQuantity, containerID) "
                             + "VALUES('" + itemList[i].getName() + "', " + itemList[i].getWeight() + ", " + itemList[i].getQuantity() + ", " + contIDList[i] + ");";

                cmd.Connection = connection;
                cmd.CommandText = query;

                cmd.ExecuteNonQuery();
            }
        }

        public int createInvoice(MySqlConnection connection, int custID, List<Container> contList)
        {
            MySqlCommand cmd = new MySqlCommand();
            double pmtAmt = 0;
            int invNum;
            for(int i = 0; i < contList.Count(); i++)
            {
                pmtAmt += contList[i].getPrice();
            }

            string query = "INSERT INTO invoice (customerID, paymentAmount) VALUES(" + custID + ", " + pmtAmt + ");";

            cmd.Connection = connection;
            cmd.CommandText = query;

            cmd.ExecuteNonQuery();

            query = "SELECT invoiceID FROM invoice WHERE customerID = " + custID + ";";

            cmd.Connection = connection;
            cmd.CommandText = query;

            MySqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            invNum = int.Parse(reader["invoiceID"].ToString());

            reader.Close();

            return invNum;
        }

        public List<int> getCustInvoices(MySqlConnection connection, int custID)
        {
            MySqlCommand cmd = new MySqlCommand();
            List<int> custInvoiceNums = new List<int>();

            string query = "SELECT DISTINCT invoiceID FROM invoice "
                           + "WHERE customerID = " + custID + ";";

            cmd.Connection = connection;
            cmd.CommandText = query;

            MySqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                custInvoiceNums.Add(int.Parse(reader["invoiceID"].ToString()));
            }

            reader.Close();

            return custInvoiceNums;
        }

        public int getItemQuantity(MySqlConnection connection, string itemName)
        {
            MySqlCommand cmd = new MySqlCommand();
            int itemQty;
            string query = "SELECT itemQuantity FROM items "
                           + "WHERE itemName = '" + itemName + "';";

            cmd.Connection = connection;
            cmd.CommandText = query;

            MySqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            itemQty = int.Parse(reader["itemQuantity"].ToString());

            reader.Close();

            return itemQty;
        }

        public void retrieveAllOfOneItem(MySqlConnection connection, int itemID, int custID, int contID)
        {
            MySqlCommand cmd = new MySqlCommand();
            string query = "DELETE FROM items "
                           + "WHERE containerID = " + contID + ";";

            cmd.Connection = connection;
            cmd.CommandText = query;

            cmd.ExecuteNonQuery();

            query = "DELETE FROM containers "
                    + "WHERE containerID = " + contID + ";";

            cmd.Connection = connection;
            cmd.CommandText = query;

            cmd.ExecuteNonQuery();
        }

        public void retrieveEntireInvoice(MySqlConnection connection, int contID)
        {
            MySqlCommand cmd = new MySqlCommand();
            string query = "DELETE FROM items "
                           + "WHERE containerID = " + contID + ";";

            cmd.Connection = connection;
            cmd.CommandText = query;

            cmd.ExecuteNonQuery();

            query = "DELETE FROM containers "
                    + "WHERE containerID = " + contID + ";";

            cmd.Connection = connection;
            cmd.CommandText = query;

            cmd.ExecuteNonQuery();
        }

        public void deleteInvoice(MySqlConnection connection, int invNum, int custID)
        {
            MySqlCommand cmd = new MySqlCommand();
            string query = "DELETE FROM invoice "
                           + "WHERE invoiceID = " + invNum + " "
                           + "AND customerID = " + custID + ";";

            cmd.Connection = connection;
            cmd.CommandText = query;

            cmd.ExecuteNonQuery();
        }

        public void retrieveXOfOneItem(MySqlConnection connection, int newQty, int itemID)
        {
            MySqlCommand cmd = new MySqlCommand();
            string query = "UPDATE items "
                           + "SET itemQuantity = " + newQty + " "
                           + "WHERE itemID = " + itemID + ";";

            cmd.Connection = connection;
            cmd.CommandText = query;

            cmd.ExecuteNonQuery();
        }
    }
}
