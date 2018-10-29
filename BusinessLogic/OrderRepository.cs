using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogin
{
    public class OrderRepository
    {
        public Order RetrieveOrder(int orderId)
        {
            var order = new Order(10);
            if(orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(2018, 10, 29, 0, 0, 0, TimeSpan.Zero);
            }
            return order;
        }

        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {
            var orderDisplay = new OrderDisplay();
            if(orderId == 10)
            {
                orderDisplay.FirstName = "Linh";
                orderDisplay.LastName = "Duy";
                orderDisplay.OrderDate = new DateTimeOffset(2018, 10, 29, 0, 0, 0, TimeSpan.Zero);
                orderDisplay.ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "StreetLine1",
                    StreetLine2 = "StreetLine2",
                    City = "HCM",
                    State = "State",
                    Country = "VietName",
                    PostalCode = "70000"
                };
            }

            orderDisplay.OrderDisplayItems = new List<OrderDisplayItem>();
            if(orderId == 10)
            {
                var orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Iphone",
                    PurchasePrice = 10M,
                    OrderQuantity = 2
                };
                orderDisplay.OrderDisplayItems.Add(orderDisplayItem);
                orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Ipad",
                    PurchasePrice = 20M,
                    OrderQuantity = 2
                };
                orderDisplay.OrderDisplayItems.Add(orderDisplayItem);
            }
            return orderDisplay;
        }
    }
}
