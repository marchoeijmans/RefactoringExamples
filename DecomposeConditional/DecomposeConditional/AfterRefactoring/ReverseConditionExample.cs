using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecomposeConditional.AfterRefactoring
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

        // Reverse condition, use guards
        public double getAdjustedCapital()
        {
            if (_capital <= 0.0) return 0.0;
            if (_rate <= 0.0 && _duration <= 0.0) return 0.0;
            return (_income / _duration) * ADJ_FACTOR; 
        }
    }
}
