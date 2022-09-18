using System;
using System.Collections.Generic;
using System.Text;

namespace NumericPrograms
{
    public class FactorialUsingRecusion
    {
        public int getFactorial(int num)
        {
            if (num == 0)
                return 1;
            return (num * getFactorial(num - 1));
        }
    }
}
