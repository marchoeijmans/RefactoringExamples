using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplaceTypeCodeWithSubClasses
{
    public class EmployeeBeforeRefactor
    {
        private int _type;

        public static readonly int Engineer = 0;
        public static readonly int Sales = 1;
        public static readonly int Manager = 2;

        public EmployeeBeforeRefactor(int type)
        {
            _type = type;
        }
    }
}
