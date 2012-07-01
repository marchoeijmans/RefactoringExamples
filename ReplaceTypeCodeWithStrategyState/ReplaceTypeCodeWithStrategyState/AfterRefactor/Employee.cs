using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplaceTypeCodeWithStrategyState.AfterRefactor
{
    public class Employee
    {
        private EmployeeType _type;

        public EmployeeType getType()
        {
            return _type;
        }

        public void setType(int arg)
        {
            _type = EmployeeType.newType(arg);
        }

        public Employee(int type)
        {
            setType(type);
        }
    }
}
