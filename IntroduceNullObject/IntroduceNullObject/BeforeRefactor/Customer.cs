using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntroduceNullObject.BeforeRefactor
{
    public class Customer
    {
        private string _firstName;
        private string _lastName;

        public Customer() { }

        public Customer(string firstName, string lastName)
        {
           _firstName = firstName;
            _lastName = lastName;
        }

        public string getName()
        {
            return string.Concat(_firstName, " ", _lastName);
        }
    }
}
