using System;
using System.Collections.Generic;
using System.Text;

namespace NumericPrograms
{
    public class OddOrEven
    {
        public string usingBitWiseOperator(int num)
        {
            return ((num & 1) == 1) ? "EVEN" : "ODD";
        }
        public string usingConditionalOperator(int num)
        {
            return ((num % 2) == 0) ? "EVEN" : "ODD";
        }
    }
}
