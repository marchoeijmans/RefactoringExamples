using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplaceTypeCodeWithSubClasses
{
    public class Manager: EmployeeAfterRefactor 
    {
        public override int getType()
        {
            return EmployeeAfterRefactor.MANAGER;
        }
    }
}
