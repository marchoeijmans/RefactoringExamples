using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplaceConditionalWithPolymorphism.AfterRefactor
{
    public class SalesMan : EmployeeType
    {
        public override int getTypeCode()
        {
            return SALESMAN;
        }

        public override int payAmount(Employee emp)
        {
            return emp.getMonthlySalary() + emp.getCommission();
        }
    }
}
