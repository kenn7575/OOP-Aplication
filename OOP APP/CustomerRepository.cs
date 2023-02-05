using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_APP;

namespace OOP_APP
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }
        //retrieve customer
        public Customer Retrieve(int customerId)
        {
            //create instance of customer class
            Customer customer = new Customer(customerId);
            //code that retrieves defined customer
            
            //temporary hard coded values to return a populated customer
            if (customerId == 1)
            {
                customer.Email = "example@gmail.com";
                customer.FName = "John";
                customer.LName = "Doe";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }
        //saves the current customer
        public bool Save(Customer customer)
        {
            //code that saves the defined customer
            return true;
        }
    }
}
