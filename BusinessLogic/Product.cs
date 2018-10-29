using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogin
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            this.ProductId = productId;
        }

        public Decimal? CurrentPrice { get; set; }

        public int ProductId { get; private set; }

        public string ProductDescription { get; set; }

        public string ProductName { get; set; }

        public bool Validate()
        {
            return !string.IsNullOrWhiteSpace(ProductName) && CurrentPrice != null;
        }

        /// <summary>
        /// Retrieve one Product.
        /// </summary>
        public Product Retrieve(int productId)
        {
            //TODO
            return new Product();
        }

        ///<summary>
        /// Retrieve all Products.
        ///</summary>
        public List<Product> Retrieve()
        {
            //TODO
            return new List<Product>();
        }

        ///<summary>
        /// Saves the current Product.
        ///</summary>
        public bool Save()
        {
            //TODO
            return true;
        }

    }
}
