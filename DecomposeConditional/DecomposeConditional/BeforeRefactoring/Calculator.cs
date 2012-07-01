using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecomposeConditional.BeforeRefactoring
{
    public class Calculator
    {
        private DateTime  SUMMER_START = new DateTime(2011,5, 1);
        private DateTime SUMMER_END = new DateTime(2011, 8, 31);

        private int _quantity;
        private int _summerRate;
        private int _winterRate;
        private int _winterServiceCharge;

        public Calculator(int quantity, int summerRate, int winterRate, int winterServiceCharge)
        {
            _quantity = quantity;
            _summerRate = summerRate;
            _winterRate = winterRate;
            _winterServiceCharge = winterServiceCharge;
            
        }

        public double calculateCharge(DateTime date)
        {
            if (date < SUMMER_START || date > SUMMER_END)
                return (_quantity * _winterRate + _winterServiceCharge);
            else
                return (_quantity * _summerRate);
        }
    }
}
