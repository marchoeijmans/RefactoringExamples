using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplaceTypeCodeWithSubClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesMan salesEmployee = new SalesMan();
            Console.WriteLine(salesEmployee.getType());

            Manager managerEmployee = new Manager();
            Console.WriteLine(managerEmployee.getType());

            Engineer engineerEmployee = new Engineer();
            Console.WriteLine(engineerEmployee.getType());

            EmployeeAfterRefactor employee0 = EmployeeAfterRefactor.create(0);
            Console.WriteLine(employee0.GetType());
            Console.WriteLine(employee0.getType());

            EmployeeAfterRefactor employee1 = EmployeeAfterRefactor.create(1);
            Console.WriteLine(employee1.GetType());
            Console.WriteLine(employee1.getType());

            EmployeeAfterRefactor employee2 = EmployeeAfterRefactor.create(2);
            Console.WriteLine(employee2.GetType());
            Console.WriteLine(employee2.getType());

            try
            {
                EmployeeAfterRefactor invalidEmployee = EmployeeAfterRefactor.create(9);
            }
            catch (ArgumentOutOfRangeException ex)
            {

                Console.WriteLine("Can not create employee with type 9");
                Console.WriteLine(ex.Message);

                Console.ReadLine();
            }
        }
    }
}
