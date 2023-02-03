using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_APP
{
    public class OrderItem
    {
        public OrderItem()
        {
        }

        public OrderItem(int orderItemID)
        {
            OrderItemID = orderItemID;
        }

        public int OrderItemID { get; private set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }

        public bool Validate()
        {
            var errorsCount = 0;
            if (OrderItemID <= 0) errorsCount++;
            if (ProductID <= 0) errorsCount++;
            if (Quantity <= 0) errorsCount++;
            if (PurchasePrice <= 0 || PurchasePrice == null) errorsCount++;

            if (errorsCount > 0) return false;
            else return true;
        }
        public OrderItem Retrieve(int orderItemID)
        {
            return new OrderItem();
        }
        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
        }
        public bool Save()
        {
            return true;
        }
    }
}
