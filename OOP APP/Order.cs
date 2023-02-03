using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_APP
{
    public class Order
    {
        public Order() { }
        public Order(int orderID)
        {
            OrderID = orderID;
        }
        //properties
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderID { get; private set; }

        //methods
        public bool Validate()
        {
            var errorsCount = 0;
            if (OrderDate == null) errorsCount++;
            if (OrderID <= 0) errorsCount++;

            //validates errorsCount
            if (errorsCount > 0) return false;
            else return true;
        }
        public bool Save()
        {
            //code that saves the defined order
            return true;
        }
        public Order Retrieve(int orderID)
        {
            //code that retrieves the defined order
            return new Order();
        }
        public List<Order> Retrieve()
        {
            //code that retrieves all orders
            return new List<Order>();
        }


    }
}
