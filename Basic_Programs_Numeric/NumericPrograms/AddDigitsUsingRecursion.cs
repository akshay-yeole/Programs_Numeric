using System;

namespace NumericPrograms
{
    public class AddDigitsUsingRecursion
    {
        static int total = 0;
        public int addDigits(int num)
        {
            if (num == 0)
                return 0;
            total = num % 10 + addDigits(num / 10);
            return total;
        }
    }
}
