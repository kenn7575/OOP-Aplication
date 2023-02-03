using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using OOP_APP;

namespace OOP_APP_BL_Test
{
    /// <summary>
    /// Summary description for OrderItemTests
    /// </summary>
    [TestClass]
    public class OrderItemTests
    {
        [TestMethod]
        public void ValidateValid()
        {
            //arrange
            var orderItem = new OrderItem(1)
            {
                Quantity = 1,
                PurchasePrice = 10.00M,
                ProductID = 1
            };
            var expected = true;

            //act
            var actual = orderItem.Validate();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateMissingOrderQuantity()
        {
            //arrange
            var orderItem = new OrderItem()
            {
                PurchasePrice = 10.00M
            };
            var expected = false;

            //act
            var actual = orderItem.Validate();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateMissingPurchasePrice()
        {
            //arrange
            var orderItem = new OrderItem()
            {
                Quantity = 1,
                ProductID = 1

            };
            var expected = false;

            //act
            var actual = orderItem.Validate();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateInvalidOrderQuantity()
        {
            //arrange
            var orderItem = new OrderItem()
            {
                Quantity = 0,
                PurchasePrice = 10.00M,
                ProductID = 1
            };
            var expected = false;

            //act
            var actual = orderItem.Validate();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateInvalidPurchasePrice()
        {
            //arrange
            var orderItem = new OrderItem()
            {
                Quantity = 1,
                PurchasePrice = 0.00M,
                ProductID = 1

            };
            var expected = false;

            //act
            var actual = orderItem.Validate();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
