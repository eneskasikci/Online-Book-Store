using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Customer
    {
        private int customerID;
        private string name;
        private string address;
        private string email;
        private string username;
        private string password;

        public string printCustomerDetails()
        {
            return customerID + "," + name + "," + address + ","
                    + email + "," + username + "," + password;
        }
        public void saveCustomer(int customerID, string name, string address, string email, string username, string password)
        {
            this.customerID = customerID;
            this.name = name;
            this.address = address;
            this.email = email;
            this.username = username;
            this.password = password;
        }
        public void printCustomerPurchases()
        {

        }
        public string Username { get { return username; }}

        public bool IsValid(string username, string password)
        {
            return this.username.Equals(username) && this.password.Equals(password);
        }
    }
}
