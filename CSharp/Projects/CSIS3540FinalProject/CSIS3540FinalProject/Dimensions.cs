using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIS3540FinalProject
{
    /*
        The Dimensions class is being used as an Interface to provide certain objects in our program access to the
        Fields and Methods within this class. Doing this allowed us to provide different objects with these Fields
        and Methods without having to hard-code them into each class.
    */

    public class Dimensions
    {
        //Fields
        private double length;
        private double width;
        private double height;

        //Methods
        public double getLength()
        {
            return length;
        }

        public double getWidth()
        {
            return width;
        }

        public double getHeight()
        {
            return height;
        }

        public double getVolume()
        {
            double volume = (length * width * height);

            return volume;
        }

        public void setLength(double length)
        {
            this.length = length;
        }

        public void setWidth(double width)
        {
            this.width = width;
        }

        public void setHeight(double height)
        {
            this.height = height;
        }
    }
}
