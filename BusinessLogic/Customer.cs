using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Customer
    {
        public Customer()
        {

        }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
        }

        public static int InstanceCount { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if(!string.IsNullOrWhiteSpace(FirstName))
                {
                    if(!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public string EmailAddress { get; set; }

        public int CustomerId { get; private set; }

        public bool Validate()
        {
            return !string.IsNullOrWhiteSpace(LastName) && !string.IsNullOrWhiteSpace(EmailAddress);
        }

        /// <summary>
        /// Retrieve one customer.
        /// </summary>
        public Customer Retrieve(int customerId)
        {
            //TODO
            return new Customer();
        }

        ///<summary>
        /// Retrieve all customers.
        ///</summary>
        public List<Customer> Retrieve()
        {
            //TODO
            return new List<Customer>();
        }

        ///<summary>
        /// Saves the current customer.
        ///</summary>
        public bool Save()
        {
            //TODO
            return true;
        }

    }
}
