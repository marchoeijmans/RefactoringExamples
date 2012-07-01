using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplaceSubClassWithFields.BeforeRefactor
{
    public class Female: Person
    {
        public override bool isMale()
        {
            return false;
        }

        public override char getCode()
        {
            return 'F';
        } 
    }
}
