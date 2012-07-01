using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplaceTypeCodeWithStrategyState.AfterRefactor
{
    /// <summary>
    /// State class
    /// </summary>
    public abstract class EmployeeType
    {
        protected EmployeeType() { }
        public const int ENGINEER = 0;
        public const int SALESMAN = 1;
        public const int MANAGER = 2;

        public abstract int getTypeCode();
        public abstract int payAmount();
        private int _monthlySalary;
        private int _bonus;
        private int _commission;

        public void setMonthlySalery(int arg)
        {
            _monthlySalary = arg;
        }

        public int getMonthlySalery()
        {
            return _monthlySalary;
        }

        public void setCommission(int arg)
        {
            _commission = arg;
        }

        public int getCommission()
        {
            return _commission;
        }

        public void setBonus(int arg)
        {
            _bonus = arg;
        }

        public int getBonus()
        {
            return _bonus;
        }

        public static EmployeeType newType(int arg)
        {
            switch (arg)
            {
                case ENGINEER:
                    return new Engineer();
                case SALESMAN:
                    return new SalesMan();
                case MANAGER:
                    return new Manager();
                default:
                    throw new ArgumentOutOfRangeException("Incorrect type.");
            }
        }
    }
}