using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIS3540FinalProject
{
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
