using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecomposeConditional.BeforeRefactoring
{
    public class ReverseConditionExample
    {
        private double _income;
        private double _capital;
        private double _rate;
        private double _duration;

        private const double ADJ_FACTOR = 3.2;

        public ReverseConditionExample(double income, double capital, double rate, double duration)
        {
            _income = income;
            _capital = capital;
            _rate = rate;
            _duration = duration;
        }

        public double getAdjustedCapital()
        {
            double result = 0.0;
            if (_capital > 0.0)
            {
                if (_rate > 0.0 && _duration > 0.0)
                {
                    result = (_income / _duration) * ADJ_FACTOR;
                }
            }
            return result;
        }
    }
}
