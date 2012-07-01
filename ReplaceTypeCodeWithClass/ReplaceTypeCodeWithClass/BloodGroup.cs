using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplaceTypeCodeWithClass
{
    public sealed class BloodGroup
    {
        public static readonly BloodGroup O = new BloodGroup(0);
        public static readonly BloodGroup A = new BloodGroup(1);
        public static readonly BloodGroup B = new BloodGroup(2);
        public static readonly BloodGroup AB = new BloodGroup(3);

        private static readonly BloodGroup[] _values = { O, A, B, AB };
        private int _code;

        public BloodGroup(int code)
        {
            _code = code;
        }

        private int getCode()
        {
            return _code;
        }

        public static BloodGroup code(int arg)
        {
            return _values[arg];
        }

        public override string ToString()
        {
            return _code.ToString();
        }
    }
}
