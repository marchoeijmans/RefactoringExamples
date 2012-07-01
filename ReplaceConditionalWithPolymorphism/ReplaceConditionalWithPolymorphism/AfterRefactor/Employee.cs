using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplaceConditionalWithPolymorphism.AfterRefactor
{
    public class Employee
    {
        private EmployeeType _type;
        private int _monthlySalary;
        private int _bonus;
        private int _commission;

        public EmployeeType getType()
        {
            return _type;
        }

        public void setType(int arg)
        {
            _type = EmployeeType.newType(arg);
        }

        public Employee(int type, int salary, int bonus, int commision)
        {
            setType(type);
            _monthlySalary = salary;
            _bonus = bonus;
            _commission = commision;
        }

        public int getMonthlySalary()
        {
            return _monthlySalary;
        }

        public int getCommission()
        {
            return _commission;
        }

        public int getBonus()
        {
            return _bonus;
        }

        public int payAmount()
        {
            return _type.payAmount(this);
        }
    }
}
