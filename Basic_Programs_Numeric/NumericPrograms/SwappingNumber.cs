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
    }
}
