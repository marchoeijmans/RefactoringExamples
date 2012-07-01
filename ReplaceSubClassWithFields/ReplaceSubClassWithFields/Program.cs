using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BR = ReplaceSubClassWithFields.BeforeRefactor;
using AR = ReplaceSubClassWithFields.AfterRefactor;

namespace ReplaceSubClassWithFields
{
    class Program
    {
        static void Main(string[] args)
        {
            BR.Male malePerson = new BR.Male();
            Console.WriteLine(malePerson.getCode());

            BR.Female femalePerson = new BR.Female();
            Console.WriteLine(femalePerson.getCode());

            AR.Person male = AR.Person.createMale();
            Console.WriteLine(male.getCode());

            AR.Person female = AR.Person.createFemale();
            Console.WriteLine(female.getCode());

            Console.ReadLine();
        }
    }
}
