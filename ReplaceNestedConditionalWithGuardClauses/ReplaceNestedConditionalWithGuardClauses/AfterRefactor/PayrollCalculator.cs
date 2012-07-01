using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplaceNestedConditionalWithGuardClauses.AfterRefactor
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
            // If the condition is an unusual condition, check the condition and return if the condition is true. This kind
            // of check is often called a guard clause
            if (_isDead) return deadAmount();
            if (_isSeparated) return separatedAmount();
            if (_isRetired) return retiredAmount();
            return normalPayAmount();
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
