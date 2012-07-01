using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplaceTypeCodeWithClass
{
    /// <summary>
    /// see: http://sourcemaking.com/refactoring/replace-type-code-with-class
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            PersonBeforeRefactor myFirstPeron = new PersonBeforeRefactor(3);
            Console.WriteLine(myFirstPeron.GetBloodGroup().ToString());


            PersonAfterRefactor mySecondPerson = new PersonAfterRefactor(BloodGroup.AB);
            Console.WriteLine(mySecondPerson.getBloodGroup().ToString());
            Console.ReadLine();
        }
    }
}
