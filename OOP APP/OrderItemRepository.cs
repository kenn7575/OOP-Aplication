using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_APP
{
    public class OrderItemRepository
    {
        public OrderItem Retrieve(int orderItemID)
        {
            //temperary hard coded values to return a populated orderItem
            OrderItem orderItem = new OrderItem(orderItemID);
            if (orderItemID == 1)
            {
                orderItem.ProductID = 1;
                orderItem.Quantity = 1;
                orderItem.PurchasePrice = 1;
            }
            return orderItem;
        }
        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
        }
        public bool Save(OrderItem orderItem)
        {
            bool success = true;
            if (orderItem.HasChanges)
            {
                if (orderItem.IsValid)
                {
                    if (orderItem.IsNeW)
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
