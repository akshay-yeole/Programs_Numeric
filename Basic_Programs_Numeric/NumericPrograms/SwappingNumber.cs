using System;
using System.Collections.Generic;
using System.Text;

namespace NumericPrograms
{
    public class SwappingNumber
    {
        public string getSwapedNumbers(int a, int b)
        {
            int temp = a;
            a = b;  
            b = temp;
           return $"{a} {b}";
        }
        public int getSwapedNumbersUsingReferenceVal(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            return 1;
        }
        public int usingBitwise(ref int a, ref int b)
        {
            a ^= b;
            b = a ^ b;
            a ^= b;
            return 1;
        }
    }
}
