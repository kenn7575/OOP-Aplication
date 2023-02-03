using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OOP_APP_BL;

namespace OOP_APP_BL_Test
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //arrange
            Customer customer = new Customer
            {
                FName = "John",
                LName = "Doe"
            };
            string expected = "John Doe";

            //act
            string actual = customer.FullName;

            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //arrange
            Customer customer = new Customer
            {
                LName = "Doe"
            };
            string expected = "Doe";

            //act
            string actual = customer.FullName;

            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //arrange
            Customer customer = new Customer
            {
                FName = "John"
            };
            string expected = "John";

            //act
            string actual = customer.FullName;

            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void StaticInstanceCountTest()
        {
            //arrange
            Customer c1 = new Customer();
            c1.FName = "John";
            Customer.InstanceCount += 1;

            Customer c2 = new Customer();
            c2.FName = "Jane";
            Customer.InstanceCount += 1;

            Customer c3 = new Customer();
            c3.FName = "Joe";
            Customer.InstanceCount += 1;

            //act

            //assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }
        [TestMethod]
        public void SuccessfulValidationTest()
        {
            //arrange
            Customer customer = new Customer(1)
            {
                FName = "John",
                LName = "Doe",
                Email = "Kenn7575@gmail.com",
                Address = "123 Main St",
                Phone = "123-456-7890"

            };
            bool expected = true;
            //act
            bool actual = customer.Validate();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FaliedValidationTest1()
        {
            //arrange
            Customer customer = new Customer(1)
            {
                FName = "John",
                LName = "",
                Email = "Kenn7575@gmail.com",
                Address = "123 Main St",
                Phone = "123-456-7890"

            };
            bool expected = false;
            //act
            bool actual = customer.Validate();
            //assert
            Assert.AreEqual(expected, actual);
        }
        public void FaliedValidationTest2()
        {
            //arrange
            Customer customer = new Customer
            {
                FName = "John",
                LName = "Jhonson",
                Email = "Kenn7575@gmail.com",
                Address = "123 Main St",
                Phone = "123-456-7890",
                //missing CustomerID
            };
            bool expected = false;
            //act
            bool actual = customer.Validate();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateConstructorTest()
        {
            //arrange
            Customer customer = new Customer(1);
            int expected = 1;
            //act
            int actual = customer.CustomerID;
            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
