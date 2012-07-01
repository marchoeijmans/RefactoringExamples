using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplaceTypeCodeWithStrategyState.AfterRefactor
{
    public class Engineer: EmployeeType
    {
        public override int getTypeCode()
        {
            return ENGINEER;
        }

        public override int payAmount()
        {
            return base.getMonthlySalery();
        }
    }
}
