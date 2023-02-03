using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_APP_BL
{
    public class Customer
    {
        public Customer()
        {
            
        }
        public Customer(int customerID)
        {
            CustomerID = customerID;
        }
        //properties
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int CustomerID { get; private set; }
        public static int InstanceCount { get; set;}
        public string FullName
        {
            get
            {
                //if FName is null or empty return LName
                if (string.IsNullOrWhiteSpace(FName)) return LName;
                //if LName is null or empty return FName
                if (string.IsNullOrWhiteSpace(LName)) return FName;
                //if FName and LName are not null or empty return FName + " " + LName
                return FName + " " + LName;
            }
        }
        //methods
        public bool Validate()
        {
            
            var errorsCount = 0;
            if (string.IsNullOrWhiteSpace(LName)) errorsCount++;
            if (string.IsNullOrWhiteSpace(FName)) errorsCount++;
            if (string.IsNullOrWhiteSpace(Email)) errorsCount++;
            if (string.IsNullOrWhiteSpace(Address)) errorsCount++;
            if (string.IsNullOrWhiteSpace(Phone)) errorsCount++;
            if (CustomerID <= 0) errorsCount++;

            //validates errorsCount
            if (errorsCount > 0) return false;
            else return true;
        }
        public bool Save()
        {
            //code that saves the defined customer
            return true;
        }
        public Customer Retrieve(int customerID)
        {
            //code that retrieves the defined customer
            return new Customer();
        }
        public List<Customer> Retrieve()
        {
            //code that retrieves all customers
            return new List<Customer>();
        }





    }
}
