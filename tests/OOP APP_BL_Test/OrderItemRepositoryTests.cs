using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OOP_APP;

namespace OOP_APP_BL_Test
{
    [TestClass]
    public class OrderItemRepositoryTests
    {
        [TestMethod]
        public void RetrieveOrderItemValid()
        {
            //arrange
            var orderItemRepository = new OrderItemRepository();
            var expected = new OrderItem(1)
            {
                ProductID = 1,
                Quantity = 1,
                PurchasePrice = 1
            };

            //act
            var actual = orderItemRepository.Retrieve(1);

            //assert
            Assert.AreEqual(expected.OrderItemID, actual.OrderItemID);
            Assert.AreEqual(expected.ProductID, actual.ProductID);
            Assert.AreEqual(expected.Quantity, actual.Quantity);
            Assert.AreEqual(expected.PurchasePrice, actual.PurchasePrice);
        }
        [TestMethod]
        public void RetrieveOrderItemMissing()
        {
            //arrange
            var orderItemRepository = new OrderItemRepository();
            var expected = new OrderItem(2)
            {
                ProductID = 2,
                Quantity = 2,
                PurchasePrice = 2
            };

            //act
            var actual = orderItemRepository.Retrieve(10);

            //assert
            Assert.AreNotEqual(expected.OrderItemID, actual.OrderItemID);
            Assert.AreNotEqual(expected.ProductID, actual.ProductID);
            Assert.AreNotEqual(expected.Quantity, actual.Quantity);
            Assert.AreNotEqual(expected.PurchasePrice, actual.PurchasePrice);
        }
        [TestMethod]
        public void SaveTestValid()
        {
            //arrange
            var orderItemRepository = new OrderItemRepository();
            var updatedOrderItem = new OrderItem(1)
            {
                ProductID = 1,
                Quantity = 1,
                PurchasePrice = 1,
                HasChanges = true
            };
            var expected = true;

            //act
            var actual = orderItemRepository.Save(updatedOrderItem);

            //assert
            Assert.AreEqual(expected, actual);
        }
            [TestMethod]
        public void SaveTestMissingPrice()
        {
            //arrange
            var orderItemRepository = new OrderItemRepository();
            var updatedOrderItem = new OrderItem(1)
            {
                ProductID = 1,
                Quantity = 1,
                PurchasePrice = null,
                HasChanges = true
            };
            var expected = false;

            //act
            var actual = orderItemRepository.Save(updatedOrderItem);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
