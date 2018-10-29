using BusinessLogin;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Test
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveOrder()
        {
            //Arrange
            var orderRepository = new OrderRepository();
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(2018, 10, 29, 0, 0, 0, TimeSpan.Zero)
            };

            //Act
            var actual = orderRepository.RetrieveOrder(10);

            //Assert
            Assert.AreEqual(expected.OrderId, actual.OrderId);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }


        [TestMethod]
        public void RetrieveOrderDisplay()
        {
            //Arrange
            var orderRepository = new OrderRepository();
            var expected = new OrderDisplay()
            {
                FirstName = "Linh",
                LastName = "Duy",
                OrderDate = new DateTimeOffset(2018, 10, 29, 0, 0, 0, TimeSpan.Zero),
                ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "StreetLine1",
                    StreetLine2 = "StreetLine2",
                    City = "HCM",
                    State = "State",
                    Country = "VietName",
                    PostalCode = "70000"
                },
                OrderDisplayItems = new List<OrderDisplayItem>()
                {
                    new OrderDisplayItem()
                    {
                        ProductName = "Iphone",
                        PurchasePrice = 10M,
                        OrderQuantity = 2
                    },
                    new OrderDisplayItem()
                    {
                        ProductName = "Ipad",
                        PurchasePrice = 20M,
                        OrderQuantity = 2
                    }
                }
            };

            //Act
            var actual = orderRepository.RetrieveOrderDisplay(10);

            //Assert
            Assert.AreEqual(expected.OrderId, actual.OrderId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);

            Assert.AreEqual(expected.ShippingAddress.AddressType, actual.ShippingAddress.AddressType);

            Assert.AreEqual(expected.OrderDisplayItems[0].OrderQuantity, actual.OrderDisplayItems[0].OrderQuantity);
        }

    }
}
