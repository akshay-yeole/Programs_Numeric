using System;
using System.Collections.Generic;
using System.Text;

namespace NumericPrograms
{
    public class FactorialUsingForLoop
    {
        public int fact = 1;
        public int getFactorial(int num)
        {
            Console.Write("Factorial :: ");
            for (int i = 1; i <= num; i++)
            {
                fact *= i;
                
            }
            return fact;
        }
    }
}
