using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntroduceNullObject.AfterRefactor
{
    public class NullCustomer: Customer
    {
        private const string DEFAULT_NAME_EMPTY_CUSTOMER = "Occupant";

        public NullCustomer(){}

        public override bool isNull()
        {
            return true;
        }

        public override string getName()
        {
            return DEFAULT_NAME_EMPTY_CUSTOMER;
        }
    }
}
