using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplaceTypeCodeWithStrategyState.AfterRefactor
{
    public class SalesMan: EmployeeType
    {
        public override int getTypeCode()
        {
            return SALESMAN;
        }

        public override int payAmount()
        {
            return base.getMonthlySalery() + base.getCommission();
        }
    }
}
