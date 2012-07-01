using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplaceNestedConditionalWithGuardClauses.BeforeRefactor
{
    public class PayrollCalculator
    {
        private bool _isDead;
        private bool _isRetired;
        private bool _isSeparated;

        public PayrollCalculator(bool isDead, bool isRetired, bool isSeparated)
        {
            _isDead = isDead;
            _isRetired = isRetired;
            _isSeparated = isSeparated;
        }
        
        public double getAmount()
        {
            double result;
            if (_isDead) 
            {
                result = deadAmount();
            }
            else 
            {
                if (_isSeparated) 
                {
                    result = separatedAmount();
                }
                else 
                {
                    if (_isRetired)
                    {
                        result = retiredAmount();
                    }
                    else 
                    {
                        result = normalPayAmount();
                    }
                }
            }
            // one exit point!
            return result;
        }

        private double deadAmount()
        {
            return 100;
        }

        private double separatedAmount()
        {
            return 200;
        }

        private double retiredAmount()
        {
            return 300;
        }

        private double normalPayAmount()
        {
            return 400;
        }
    }
}
