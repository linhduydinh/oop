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
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveProduct()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                ProductName = "Iphone",
                ProductDescription = "Iphone Description",
                CurrentPrice = 11.6M
            };

            //Act
            var actual = productRepository.RetrieveProduct(2);

            //Assert
            Assert.AreEqual(expected.ProductId, actual.ProductId);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }
    }
}
