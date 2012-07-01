using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntroduceNullObject.AfterRefactor
{
    public class Customer: INullable
    {
        private string _firstName;
        private string _lastName;

        public static NullCustomer newNull()
        {
            return new NullCustomer();
        }

        public Customer(){ }

        public Customer(string firstName, string lastName)
        {
            setName(firstName, lastName);
        }

        public virtual bool isNull()
        {
            return false;
        }

        private void setName(string firstName, string lastName)
        {
            if (!string.IsNullOrEmpty(firstName))
                _firstName = firstName;
            else
                throw new ArgumentNullException("Firstname cannot be empty.");

            if (!string.IsNullOrEmpty(lastName))
                _lastName = lastName;
            else
                throw new ArgumentNullException("Lastname cannot be empty.");
        }

        public virtual string getName()
        {
            return string.Concat(_firstName, " ", _lastName);
        }
    }
}
