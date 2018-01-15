using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIS3540FinalProject
{
   public class Customer
    {
        //Fields
        string fname;
        string lname;
        string phone;
        string email;
        string company;
        string address;

        //Constructor
        public Customer(string fname, string lname, string phone, string email, string company, string address)
        {
            this.fname = fname;
            this.lname = lname;
            this.phone = phone;
            this.email = email;
            this.company = company;
            this.address = address;
        }

        //Methods
        public string getName()
        {
            string fullName = fname + " " + lname;

            return fullName;
        }

        public string getPhone()
        {
            return phone;
        }

        public string getEmail()
        {
            return email;
        }

        public string getCompany()
        {
            return company;
        }

        public string getAddress()
        {
            return address;
        }

        public void setName(string fname, string lname)
        {
            this.fname = fname;
            this.lname = lname; 
        }

        public void setPhone(string phone)
        {
            this.phone = phone;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public void setCompany(string company)
        {
            this.company = company;
        }

        public void setAddress(string address)
        {
            this.address = address;
        }

        public override string ToString()
        {
            return "First Name: " + fname + "\n"
                    + "Last Name: " + lname + "\n"
                    + "Phone: " + phone + "\n"
                    + "Email: " + email + "\n"
                    + "Company: " + company + "\n"
                    + "Address: " + address;
        }
    }
}
