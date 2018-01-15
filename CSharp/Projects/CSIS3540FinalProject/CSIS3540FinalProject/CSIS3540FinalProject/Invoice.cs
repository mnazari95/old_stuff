using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIS3540FinalProject
{
    class Invoice
    {
        //Fields
        int customerID;
        int invoiceNumber;
        string custName;
        string custAddress;
        string custCompany;
        double invAmount;
        List<Container> contList;

        //Constructor
        public Invoice(int custID, string custName, string custAddress, string custCompany, List<Container> contList)
        {
            this.customerID = custID;
            this.custName = custName;
            this.custAddress = custAddress;
            this.custCompany = custCompany;
            this.contList = new List<Container>();

            for(int i = 0; i < contList.Count(); i++)
            {
                this.contList.Add(contList[i]);
            }

            /*this.invAmount = total amount from contList*/
        }

        //Methods
        public int getCustomerID()
        {
            return customerID;
        }

        public int getInvoiceNumber()
        {
            return invoiceNumber;
        }

        public string getcustName()
        {
            return custName;
        }

        public string getcustAddress()
        {
            return custAddress;
        }

        public string getcustCompany()
        {
            return custCompany;
        }

        public double getinvAmount()
        {
            return invAmount;
        }


        public void setCustomerID(int CustomerID)
        {
            this.customerID = CustomerID;
        }

        public void setInvoiceNumber(int InvoiceNumber)
        {
            this.invoiceNumber = InvoiceNumber;
        }

        public void setcustName(string custName)
        {
            this.custName = custName;
        }

        public void setcustAddress(string custAddress)
        {
            this.custAddress = custAddress;
        }

        public void setcustCompany(string custCompany)
        {
            this.custCompany = custCompany;
        }

        public void setinvAmount(double invAmount)

        {
            this.invAmount = invAmount;
        }
    }
}
