using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecomposeConditional.AfterRefactoring
{
    public class OrsCalculatorExample
    {
        private int _seniority;
        private int _monthsDisabled;
        private bool _isPartTime;

        public OrsCalculatorExample(int seniority, int monthsDisabled, bool isPartTime)
        {
            _seniority = seniority;
            _monthsDisabled = monthsDisabled;
            _isPartTime = isPartTime;
        }

        public double disablityAmount()
        {
            if (isNotEligibleForDisablity())
            {
                return 0;
            }
            else
            {
                return 2000; // calculated value
            }
        }
        
        // geeft de intensie aan wat er getest wordt.
        private bool isNotEligibleForDisablity()
        {
            return ((_seniority < 2) || (_monthsDisabled < 12) || (_isPartTime));
        }
    }
}
