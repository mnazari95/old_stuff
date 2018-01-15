using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIS3540FinalProject
{
    public class Rack : Dimensions
    {
        //Fields
        private string name;
        private int aisle;
        private int id;

        //Constructors
        public Rack()
        {

        }

        public Rack(double w, double l, double h)
        {
            this.setWidth(w);
            this.setLength(l);
            this.setHeight(h);
        }

        //Methods
        public string getName()
        {
            return name;
        }

        public int getAisle()
        {
            return aisle;
        }

        public int getId()
        {
            return id;
        }
    }
}
