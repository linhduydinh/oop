using System;
using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogic.Test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // Arrange
            Customer customer = new Customer();
            customer.FirstName = "Linh";
            customer.LastName = "Duy";
            string expected = "Duy, Linh";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // Arrange
            Customer customer = new Customer();
            customer.LastName = "Duy";
            string expected = "Duy";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // Arrange
            Customer customer = new Customer();
            customer.FirstName = "Linh";
            string expected = "Linh";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ObjectReferenceTest()
        {
            //Arrange
            var c1 = new Customer();
            c1.FirstName = "Linh";
            var c2 = c1;
            c2.FirstName = "New Linh";
            string expected = "New Linh";

            //Act

            //Assert
            Assert.AreEqual(c1.FirstName, expected);

        }

        [TestMethod]
        public void StaticTest()
        {
            //Arrange
            var c1 = new Customer();
            Customer.InstanceCount += 1;
            var c2 = new Customer();
            Customer.InstanceCount += 1;
            var c3 = new Customer();
            Customer.InstanceCount += 1;

            //Act

            //Assert
            Assert.AreEqual(Customer.InstanceCount, 3);
        }
    }
}
