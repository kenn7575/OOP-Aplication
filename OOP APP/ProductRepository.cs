﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_APP;

namespace OOP_APP
{
    public class ProductRepository
    {
        //retrieve one product
        public Product Retrieve(int productId)
        {
            //create instance of product class
            Product product = new Product(productId);
            //code that retrieves defined product
            
            //temporary hard coded values to return a populated product
            if (productId == 1)
            {
                product.ProductName = "Sunflowers";
                product.Description = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers";
                product.CurrentPrice = 15.96M;
            }
            return product;
        }
        //saves the current product
        public bool Save(Product product)
        {
            bool success = true;
            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNeW)
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
