using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplaceConditionalWithPolymorphism.BeforeRefactor
{
    public class Employee
    {
        private int _type;
        private int _monthlySalary;
        private int _commission;
        private int _bonus;

        public const int ENGINEER = 0;
        public const int SALESMAN = 1;
        public const int MANAGER = 2;

        public Employee(int type, int salary, int commision, int bonus)
        {
            _type = type;
            _monthlySalary = salary;
            _commission = commision;
            _bonus = bonus;
        }

        public int payAmount()
        {
            switch (_type)
            {
                case ENGINEER:
                    return _monthlySalary;
                case SALESMAN:
                    return _monthlySalary + _commission;
                case MANAGER:
                    return _monthlySalary + _bonus;
                default:
                    throw new ArgumentOutOfRangeException("Incorrect Employee");
            }
        }
    }
}
