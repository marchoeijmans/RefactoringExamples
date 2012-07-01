using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecomposeConditional.BeforeRefactoring
{
    public class OrsCalculatorExample
    {
        private int _seniority;
        private int _monthsDisabled;
        private bool _isSenior;

        public OrsCalculatorExample(int seniority, int monthsDisabled, bool isSenior)
        {
            _seniority = seniority;
            _monthsDisabled = monthsDisabled;
            _isSenior = isSenior;
        }

        public double disablityAmount()
        {
            if ((_seniority < 2) || (_monthsDisabled < 12) || (_isSenior))
            {
                return 0;
            }
            else
            {
                return 2000; // calculated value
            }
        }
    }
}
