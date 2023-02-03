﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_APP
{
    public class Product
    {
        public Product()
        {
            
        }
        public Product(int productID)
        {
            ProductID = productID;
        }

        public int ProductID { get; private set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }

        public bool Validate()
        {
            var errorsCount = 0;
            if (string.IsNullOrWhiteSpace(ProductName)) errorsCount++;
            if (string.IsNullOrWhiteSpace(Description)) errorsCount++;
            if (CurrentPrice <= 0 || CurrentPrice == null) errorsCount++;
            if (ProductID <= 0) errorsCount++;
            if (errorsCount > 0) return false;
            else return true;
        }
        public Product Retrieve(int productID)
        {
            return new Product();
        }
        public List<Product> Retrieve()
        {
            return new List<Product>();
        }
        public bool Save()
        {
            return true;
        }
    }
}
