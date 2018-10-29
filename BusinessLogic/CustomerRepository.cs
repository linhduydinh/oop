using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogin
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            var customer = new Customer(customerId);
            if (customerId == 1)
            {
                customer.EmailAddress = "linhduydinh@gmail.com";
                customer.FirstName = "Linh";
                customer.LastName = "Duy";
            }
            return customer;
        }
    }
}
