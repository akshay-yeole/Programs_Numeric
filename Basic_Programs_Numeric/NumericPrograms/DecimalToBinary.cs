using System;
using System.Collections.Generic;
using System.Text;

namespace NumericPrograms
{
    public class DecimalToBinary
    {
        public string getBinary(int num)
        {
            string res="";
            for (int i = 0; num > 0; i++)
            {
                res = (num % 2).ToString()+res;
                num /= 2;
            }
            return res;
        }
    }
}
