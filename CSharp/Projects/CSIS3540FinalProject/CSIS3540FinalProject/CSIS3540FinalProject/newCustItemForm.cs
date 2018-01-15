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
        int numOfItems;
        List<Item> itemList;
        List<Container> contList;
        Customer customer;

        public newCustItemForm(int numItems, List<Item> itmList, List<Container> cntList, Customer cust)
        {
            InitializeComponent();
            numOfItems = numItems;
            itemList = itmList;
            contList = cntList;
            customer = cust;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            Container container = new Container();

            for (int i = 0; i < int.Parse(quantityText.Text); i++)
            {
                Item item = new Item(nameText.Text, int.Parse(lengthText.Text), int.Parse(widthText.Text), int.Parse(heightText.Text), int.Parse(quantityText.Text), double.Parse(weightText.Text));
                container.addItem(item);
            }

            contList.Add(container);

            itemList = container.getItemList();

            for (int i = 0; i < itemList.Count(); i++)
            {
                MessageBox.Show(itemList[i].ToString());
            }

            numOfItems--;

            if (numOfItems != 0)
            {
                newCustItemForm newForm = new newCustItemForm(numOfItems, itemList, contList, customer);
                newForm.Show();
                this.Close();
            }
            else
            {
                mainCustScreen mainScreen = new mainCustScreen(customer, contList);
                mainScreen.Show();
                this.Close();
            }
        }
    }
}
