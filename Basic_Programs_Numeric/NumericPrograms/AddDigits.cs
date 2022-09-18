using System;

namespace NumericPrograms
{
    public class AddDigits
    {
        static int total = 0;
        public int addDigits(int num)
        {
            int sum = 0,rem;
            while (num !=0)
            {
                rem = num % 10;
                sum += rem;
                num /= 10;
            }
            return sum;
        }
        public int addDigitsUsingRecursion(int num)
        {
            if (num == 0)
                return 0;
            total = num % 10 + addDigits(num / 10);
            return total;
        }
    }
}
