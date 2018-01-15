using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIS3540FinalProject
{
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

        //Constructor
        public Container()
        {
            this.itemList = new List<Item>();
        }

        public Container(double w, double l, double h, string locCode)
        {
            this.setWidth(w);
            this.setHeight(h);
            this.setLength(l);
            this.locationCode = locCode;
            this.itemList = new List<Item>();
            this.pricePerMnth = (this.getVolume() * 0.5);
        }

        //Methods
        public int getID()
        {
            return id;
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

        public void addItem(Item item)
        {
            itemList.Add(item);
            itemQuantity = itemList.Count();
            for(int i = 0; i < itemList.Count(); i++)
            {
                totalWeight += itemList[i].getWeight();
                totalVolume += itemList[i].getVolume();
            }
        }

        public List<Item> getItemList()
        {
            return this.itemList;
        }

        public override string ToString()
        {
            return "Container Weight: " + getWeight().ToString() + "\n"
                    + "Container Volume: " + getVolume().ToString();
        }
    }
}
