using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIS3540FinalProject
{
    class Shelf : Dimensions
    {
        //Fields
        private int id;
        private int shelfNumber;

        //Constructors
        public Shelf()
        {

        }

        public Shelf(double w, double l, double h)
        {
            this.setWidth(w);
            this.setLength(l);
            this.setHeight(h);
        }

        //Methods
        public int getId()
        {
            return id;
        }

        public int getShelfNumber()
        {
            return shelfNumber;
        }

        public void setShelfNumber(int shelfNumber)
        {
            this.shelfNumber = shelfNumber;
        }
    }
}
