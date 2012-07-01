using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplaceTypeCodeWithStrategyState.AfterRefactor
{
    public class Manager: EmployeeType
    {
        public override int getTypeCode()
        {
            return MANAGER;
        }

        public override int payAmount()
        {
            return base.getMonthlySalery() + base.getBonus();
        }
    }
}
