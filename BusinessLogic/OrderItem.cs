using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogin
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }

        public int OrderQuantity { get; set; }

        public int ProductId { get; set; }

        public decimal? PurchasePrice { get; set; }

        public bool Validate()
        {
            return OrderQuantity > 0 && ProductId > 0 && PurchasePrice != null;
        }

        /// <summary>
        /// Retrieve one OrderItem.
        /// </summary>
        public OrderItem Retrieve(int productId)
        {
            //TODO
            return new OrderItem();
        }

        ///<summary>
        /// Retrieve all OrderItems.
        ///</summary>
        public List<OrderItem> Retrieve()
        {
            //TODO
            return new List<OrderItem>();
        }

        ///<summary>
        /// Saves the current OrderItem.
        ///</summary>
        public bool Save()
        {
            //TODO
            return true;
        }
    }
}
