using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIS3540FinalProject
{
    public class Item : Dimensions
    {
        //Fields
        private int id;
        private string name;
        private int quantity;
        private double itemWeight;

        //Constructor
        public Item(string name, int quantity, double weight)
        {
            this.name = name;
            this.quantity = quantity;
            this.itemWeight = weight;
        }
        
        //Methods
        public string getName()
        {
            return this.name;
        }

        public int getQuantity()
        {
            return this.quantity;
        }

        public double getWeight()
        {
            return this.itemWeight;
        }

        public override string ToString()
        {
            return "Name: " + name + "\n"
                    + "Length : " + getLength().ToString() + "\n"
                    + "Width: " + getWidth().ToString() + "\n"
                    + "Height: " + getHeight().ToString() + "\n"
                    + "Quantity: " + quantity + "\n"
                    + "Weight: " + itemWeight;
        }
    }
}
