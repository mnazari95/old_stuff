using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIS3540FinalProject
{
    /*
        This class represents Containers for our warehouse system. For our purposes a Container is a cardboard box that
        encapsulates a set of Items the user wishes to store.
    */

    public class Container : Dimensions
    {
        //Fields
        private int id;
        private List<Item> itemList;
        private int itemQuantity;
        private double totalVolume;
        private double totalWeight;
        private string locationCode;
        private double pricePerMnth;
        private string storageDate;
        private int invoiceNumber;

        //Constructor
        public Container()
        {
            this.itemList = new List<Item>();
        }

        public Container(double w, double l, double h /*string locCode*/)
        {
            this.setWidth(w);
            this.setHeight(h);
            this.setLength(l);
            //this.locationCode = locCode;
            this.itemList = new List<Item>();
            this.pricePerMnth = (this.getVolume() * 0.5);
            this.storageDate = DateTime.Now.ToString("yyyy-MM-dd");
        }

        //Methods
        public int getID()
        {
            return id;
        }

        public int getInvoiceNumber()
        {
            return this.invoiceNumber;
        }

        public double getWeight()
        {
            return totalWeight;
        }

        public double getPrice()
        {
            return pricePerMnth;
        }

        public string getLocation()
        {
            return locationCode;
        }

        public void setInvoiceNumber(int invNum)
        {
            this.invoiceNumber = invNum;
        }

        public void setID(int ID)
        {
            this.id = ID;
        }

        public void setLocation(string locCode)
        {
            this.locationCode = locCode;
        }

        public void setQuantity(int quan)
        {
            itemQuantity = quan;
        }

        public void setWeight(double wei)
        {
            totalWeight = wei;
        }

        public void setVolume(double volume)
        {
            this.totalVolume = volume;
        }

        public string getStoreDate()
        {
            return this.storageDate;
        }

        public int getQuantity()
        {
            return this.itemQuantity;
        }

        public void addItem(Item item)
        {
            itemList.Add(item);
            itemQuantity = itemList.Count();

            totalWeight += itemList[itemList.Count() - 1].getWeight();
            totalVolume += itemList[itemList.Count() - 1].getVolume();
        }

        public List<Item> getItemList()
        {
            return this.itemList;
        }

        public override string ToString()
        {
            return "Container Weight: " + getWeight().ToString() + "\n"
                    + "Container Volume: " + getVolume().ToString() + "\n"
                    + "Invoice Number: " + invoiceNumber.ToString();
        }
    }
}
