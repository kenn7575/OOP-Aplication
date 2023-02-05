using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OOP_APP;
namespace OOP_APP_BL_Test
{
    [TestClass]
    public class OrderRepositoryTests
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //arrange
            var orderRepository = new OrderRepository();
            var expected = new Order(1)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
            };

            //act
            var actual = orderRepository.Retrieve(1);

            //assert
            Assert.AreEqual(expected.OrderID, actual.OrderID);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
        [TestMethod]
        public void SaveTestValid()
        {
            //arrange
            var orderRepository = new OrderRepository();
            var updatedOrder = new Order(1)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
            };
            var expected = true;
            //act
            var actual = orderRepository.Save(updatedOrder);
            //assert
            Assert.AreEqual(expected, actual);
        }
        
    }
}
