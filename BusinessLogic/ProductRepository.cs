using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogin
{
    public class ProductRepository
    {
        public Product RetrieveProduct(int productId)
        {
            var product = new Product(productId);
            if(productId == 2)
            {
                product.ProductName = "Iphone";
                product.ProductDescription = "Iphone Description";
                product.CurrentPrice = 11.6M;
            }
            return product;
        }
    }
}
