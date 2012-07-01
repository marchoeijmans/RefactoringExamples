using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BR = ReplaceNestedConditionalWithGuardClauses.BeforeRefactor;
using AR = ReplaceNestedConditionalWithGuardClauses.AfterRefactor;


namespace ReplaceNestedConditionalWithGuardClauses
{
    class Program
    {
        static void Main(string[] args)
        {
            BR.PayrollCalculator deadCalculator = new BR.PayrollCalculator(true, false, false);
            Console.WriteLine(deadCalculator.getAmount());

            BR.PayrollCalculator retiredCalculator = new BR.PayrollCalculator(false, true, false);
            Console.WriteLine(retiredCalculator.getAmount());

            BR.PayrollCalculator separatedCalculator = new BR.PayrollCalculator(false, false, true);
            Console.WriteLine(separatedCalculator.getAmount());

            BR.PayrollCalculator normalCalculator = new BR.PayrollCalculator(false, false, false);
            Console.WriteLine(normalCalculator.getAmount());

            AR.PayrollCalculator deadCalculatorRefactored = new AR.PayrollCalculator(true, false, false);
            Console.WriteLine(deadCalculatorRefactored.getAmount());

            AR.PayrollCalculator retiredCalculatorRefactored = new AR.PayrollCalculator(false, true, false);
            Console.WriteLine(retiredCalculatorRefactored.getAmount());

            AR.PayrollCalculator separatedCalculatorRefactored = new AR.PayrollCalculator(false, false, true);
            Console.WriteLine(separatedCalculatorRefactored.getAmount());

            AR.PayrollCalculator normalCalculatorRefactored = new AR.PayrollCalculator(false, false, false);
            Console.WriteLine(normalCalculatorRefactored.getAmount());

            Console.ReadLine();

        }
    }
}
