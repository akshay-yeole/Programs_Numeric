using System;
using System.Collections.Generic;
using System.Text;

namespace NumericPrograms
{
    public class AddNNumber
    {
        public int getAdditionOfNum(int num)
        {
            int total = 0;
            for (int i = 0; i <= num; i++)
            {
                total += i;
            }
            return total;
        }
    }
}
