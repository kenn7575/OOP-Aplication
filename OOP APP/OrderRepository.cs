﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace OOP_APP
{
    public class OrderRepository
    {
        
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);
            //code that retrieves defined order

            //temporary hard coded values to return a populated order
            if (orderId == 1)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }
            return order;
        }
        public bool Save(Order order)
        {
            bool success = true;
            if (order.HasChanges)
            {
                if (order.IsValid)
                {
                    if (order.IsNeW)
                    {
                        //call an insert stored procedure
                    }
                    else
                    {
                        //call an update stored procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
