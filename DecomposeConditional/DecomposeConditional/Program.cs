using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BR = DecomposeConditional.BeforeRefactoring;
using AR = DecomposeConditional.AfterRefactoring;

namespace DecomposeConditional
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime summerday = new DateTime(2011, 7, 1);
            DateTime notSummerday = new DateTime(2011, 11, 1);

            BR.Calculator calculator = new BR.Calculator(1000000, 10000, 270, 370);
            Console.WriteLine(string.Format("Summer charge {0}: {1}", summerday, calculator.calculateCharge(summerday)));
            Console.WriteLine(string.Format("Winter charge {0}: {1}", notSummerday, calculator.calculateCharge(notSummerday)));

            AR.Calculator refactoredCalculator = new AR.Calculator(1000000, 10000, 270, 370);
            Console.WriteLine(string.Format("Summer charge {0}: {1}", summerday, refactoredCalculator.calculateCharge(summerday)));
            Console.WriteLine(string.Format("Winter charge {0}: {1}", notSummerday, refactoredCalculator.calculateCharge(notSummerday)));

            BR.OrsCalculatorExample orsCalculator = new BR.OrsCalculatorExample(2, 14, false);
            Console.WriteLine(orsCalculator.disablityAmount());

            BR.OrsCalculatorExample orsCalculatorDisabled = new BR.OrsCalculatorExample(1, 14, false);
            Console.WriteLine(orsCalculatorDisabled.disablityAmount());


            AR.OrsCalculatorExample orsCalculatorRefactored = new AR.OrsCalculatorExample(2, 14, false);
            Console.WriteLine(orsCalculatorRefactored.disablityAmount());

            AR.OrsCalculatorExample orsCalculatorRefactoredDisabled = new AR.OrsCalculatorExample(1, 14, false);
            Console.WriteLine(orsCalculatorRefactoredDisabled.disablityAmount());

            BR.ReverseConditionExample adjustedCapitalCalculator = new BR.ReverseConditionExample(200, 12, 3, 20);
            Console.WriteLine(adjustedCapitalCalculator.getAdjustedCapital());

            BR.ReverseConditionExample adjustedCapitalCalculatorZero = new BR.ReverseConditionExample(500, 0, 0, 2);
            Console.WriteLine(adjustedCapitalCalculatorZero.getAdjustedCapital());

            AR.ReverseConditionExample adjustedCapitalCalculatorRefactored = new AR.ReverseConditionExample(200, 12, 3, 20);
            Console.WriteLine(adjustedCapitalCalculatorRefactored.getAdjustedCapital());

            AR.ReverseConditionExample adjustedCapitalCalculatorZeroRefactored = new AR.ReverseConditionExample(500, 0, 0, 2);
            Console.WriteLine(adjustedCapitalCalculatorZeroRefactored.getAdjustedCapital());


            Console.ReadLine();
        }
    }
}
