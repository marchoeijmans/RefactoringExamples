using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplaceTypeCodeWithSubClasses
{
    public class SalesMan: EmployeeAfterRefactor
    {
        public override int getType()
        {
            return EmployeeAfterRefactor.SALESMAN;
        }
    }
}
