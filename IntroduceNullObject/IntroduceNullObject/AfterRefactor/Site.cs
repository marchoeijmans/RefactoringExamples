using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntroduceNullObject.AfterRefactor
{
    public class Site
    {
        private Customer _customer;

        public Customer getCustomer()
        {
            return (_customer == null) ? Customer.newNull() : _customer;
        }

        public void setCustomer(string firstName, string lastName)
        {
            _customer = new Customer(firstName, lastName);
        }
    }
}
