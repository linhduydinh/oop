using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogin
{
    public class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }

        public int OrderId { get; private set; }

        public bool Validate()
        {
            return OrderDate != null;
        }

        /// <summary>
        /// Retrieve one Order.
        /// </summary>
        public Order Retrieve(int orderId)
        {
            //TODO
            return new Order();
        }

        ///<summary>
        /// Retrieve all Orders.
        ///</summary>
        public List<Order> Retrieve()
        {
            //TODO
            return new List<Order>();
        }

        ///<summary>
        /// Saves the current Order.
        ///</summary>
        public bool Save()
        {
            //TODO
            return true;
        }
    }
}
