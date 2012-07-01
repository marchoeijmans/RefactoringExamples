using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplaceTypeCodeWithSubClasses
{
    public abstract class EmployeeAfterRefactor
    {
        private int _type;

        protected const int ENGINEER = 0;
        protected const int SALESMAN = 1;
        protected const int MANAGER = 2;

        public static EmployeeAfterRefactor create(int type)
        {
            switch (type)
            {
                case ENGINEER:
                    return new Engineer();
                case SALESMAN: 
                    return new SalesMan();
                case MANAGER:
                    return new Manager(); 
                default:
                    throw new ArgumentOutOfRangeException("Incorrect type code value");

            }
        }
        
        protected EmployeeAfterRefactor(int type)
        {
            _type = type;
        }
        
        protected EmployeeAfterRefactor() { }

        public virtual int getType()
        {
            return _type;
        }
    }
}
