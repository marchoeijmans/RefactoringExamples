using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplaceTypeCodeWithClass
{
    public class PersonAfterRefactor
    {
        private BloodGroup _bloodGroup;

        public PersonAfterRefactor(BloodGroup bloodgroup)
        {
            _bloodGroup = bloodgroup;
        }

        public BloodGroup getBloodGroup()
        {
            return _bloodGroup;
        }

        public void setBloodGroup(int arg)
        {
            _bloodGroup = BloodGroup.code(arg);
        }
    }
}
