using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BR = ReplaceTypeCodeWithStrategyState.BeforeRefactor;
using AR = ReplaceTypeCodeWithStrategyState.AfterRefactor;

namespace ReplaceTypeCodeWithStrategyState
{
    class Program
    {
        static void Main(string[] args)
        {
            // start wiht as Engineer
            AR.Employee employee = new AR.Employee(AR.EmployeeType.ENGINEER);
            employee.getType().setMonthlySalery(1800);
            Console.WriteLine(string.Format("The amount for an engineer is: {0}", employee.getType().payAmount()));
            
            // promote to Salesman
            employee.setType(AR.EmployeeType.SALESMAN);
            employee.getType().setMonthlySalery(2000);
            employee.getType().setCommission(1000);
            Console.WriteLine(string.Format("The amount for a salesman is: {0}", employee.getType().payAmount()));
            
            //promote to Manager
            employee.setType(AR.EmployeeType.MANAGER);
            employee.getType().setMonthlySalery(3000);
            employee.getType().setBonus(4000);
            Console.WriteLine(string.Format("The amount for a manager is: {0}", employee.getType().payAmount()));

            Console.ReadLine();
        }
    }
}
