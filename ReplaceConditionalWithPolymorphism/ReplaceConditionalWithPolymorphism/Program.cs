using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BR = ReplaceConditionalWithPolymorphism.BeforeRefactor;
using AR = ReplaceConditionalWithPolymorphism.AfterRefactor;

namespace ReplaceConditionalWithPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            int monthlySalary = 2000;
            int commision = 1500;
            int bonus = 2500;

            BR.Employee engineer = new BR.Employee(BR.Employee.ENGINEER, monthlySalary, commision, bonus);
            Console.WriteLine(string.Format("Engineer amount: {0}", engineer.payAmount()));

            BR.Employee salesMan = new BR.Employee(BR.Employee.SALESMAN, monthlySalary, commision, bonus);
            Console.WriteLine(string.Format("SalesMan amount: {0}", salesMan.payAmount()));

            BR.Employee manager = new BR.Employee(BR.Employee.MANAGER, monthlySalary, commision, bonus);
            Console.WriteLine(string.Format("Manager amount: {0}", manager.payAmount()));

            AR.Employee employee = new AR.Employee(AR.EmployeeType.ENGINEER, monthlySalary, commision, bonus);
            Console.WriteLine(string.Format("Engineer amount: {0}", employee.payAmount()));

            employee.setType(AR.EmployeeType.MANAGER);
            Console.WriteLine(string.Format("Manager amount: {0}", employee.payAmount()));

            employee.setType(AR.EmployeeType.SALESMAN);
            Console.WriteLine(string.Format("SalesMan amount: {0}", employee.payAmount()));

            Console.ReadLine();
        }
    }
}