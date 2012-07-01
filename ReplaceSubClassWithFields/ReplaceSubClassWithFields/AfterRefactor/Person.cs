using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplaceSubClassWithFields.AfterRefactor
{
    public class Person
    {
        private readonly bool _isMale;
        private readonly char _code;

        public Person() { }

        private Person(bool isMale, char code)
        {
            _isMale = isMale;
            _code = code;
        }
        public bool isMale()
        {
            return _isMale;
        }
        public char getCode()
        {
            return _code;
        }


        public static Person createMale()
        {
            return new Person(true, 'M');
        }

        public static Person createFemale()
        {
            return new Person(false, 'F');
        }
    }
}
