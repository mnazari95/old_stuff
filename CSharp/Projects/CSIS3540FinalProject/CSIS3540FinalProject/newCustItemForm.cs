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
    public partial class newCustItemForm : Form
    {
        //Initializing variables for later use
        int numOfItems;
        List<Container> contList;
        List<Item> itemList;
        Customer customer;

        public newCustItemForm(int numItems, List<Container> cntList, List<Item> itmList, Customer cust)
        {
            //Constructor for newCustItemForm - initializes variables with values from previous Form
            InitializeComponent();
            numOfItems = numItems;
            contList = cntList;
            itemList = itmList;
            customer = cust;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            //The "Submit" button will create a Container and Item object for each Item the user wants to store. Each Item object is
            //stored within the associated Container object.
            Container container;
            Item item;

            container = new Container(double.Parse(widthText.Text), double.Parse(lengthText.Text), double.Parse(heightText.Text));
            item = new Item(nameText.Text, int.Parse(quantityText.Text), double.Parse(weightText.Text));
            container.addItem(item);
            contList.Add(container);
            itemList.Add(item);

            //Flag variable for the number of Items the user wishes to enter.
            numOfItems--;

            //If the number of items left to enter is more than zero, create a new version of the same Form and prompt the 
            //user for the information for their next Item.
            if (numOfItems != 0)
            {
                newCustItemForm newForm = new newCustItemForm(numOfItems, contList, itemList, customer);
                newForm.Show();
                this.Hide();
            }
            else
            {
                //If all Items have been entered, pass all applicable information and create the Main Customer Portal Form.
                mainCustScreen mainScreen = new mainCustScreen(customer, contList, itemList);
                mainScreen.Show();
                this.Hide();
            }
        }
    }
}
