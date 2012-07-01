using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplaceSubClassWithFields.BeforeRefactor
{
    public class Male: Person
    {
        public override bool isMale()
        {
            return true;
        }

        public override char getCode()
        {
            return 'M';
        } 
    }
}
