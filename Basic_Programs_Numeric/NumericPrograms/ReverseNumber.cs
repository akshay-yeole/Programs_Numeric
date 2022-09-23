using System;
using System.Collections.Generic;
using System.Text;

namespace NumericPrograms
{
    public class ReverseNumber
    {
        public int getReverseNumber(int num)
        {
            int rev = 0;
            while (num != 0)
            {
                rev*=10;
                rev += (num%10);
                num /= 10;
            }
            return rev;
        }
    }
}
