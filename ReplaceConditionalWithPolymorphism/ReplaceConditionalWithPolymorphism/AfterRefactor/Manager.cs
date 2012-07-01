using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplaceConditionalWithPolymorphism.AfterRefactor
{
    public class Manager : EmployeeType
    {
        public override int getTypeCode()
        {
            return MANAGER;
        }

        public override int payAmount(Employee emp)
        {
            return emp.getMonthlySalary() + emp.getBonus();
        }
    }
}
