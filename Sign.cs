using System;
using System.Collections.Generic;
using System.Text;

namespace SignCalculator
{
    class Sign
    {
        public string name;
        public int dayBegin;
        public int monthBegin;
        public int dayEnd;
        public int monthEnd;
        public string caracterisct;

        override public string ToString() => name + "\r\n" + caracterisct;
    }
}
