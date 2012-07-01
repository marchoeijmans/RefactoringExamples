using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplaceConditionalWithPolymorphism.AfterRefactor
{
    /// <summary>
    /// State class
    /// </summary>
    public abstract class EmployeeType
    {
        protected EmployeeType() { }
        public const int ENGINEER = 0;
        public const int SALESMAN = 1;
        public const int MANAGER = 2;

        public abstract int getTypeCode();
        public static EmployeeType newType(int arg)
        {
            switch (arg)
            {
                case ENGINEER:
                    return new Engineer();
                case SALESMAN:
                    return new SalesMan();
                case MANAGER:
                    return new Manager();
                default:
                    throw new ArgumentOutOfRangeException("Incorrect type.");
            }
        }

        public abstract int payAmount(Employee emp);

    }
}
