using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplaceTypeCodeWithClass
{
    public class PersonBeforeRefactor
    {
        public static readonly int O = 0;
        public static readonly int A = 1;
        public static readonly int B = 2;
        public static readonly int AP = 3;

        private int _bloodGroup;

        public PersonBeforeRefactor(int bloodGroup)
        {
            _bloodGroup = bloodGroup;
        }

        public void SetBloodGroup(int arg)
        {
            _bloodGroup = arg;
        }

        public int GetBloodGroup()
        {
            return _bloodGroup;
        }
    }
}

