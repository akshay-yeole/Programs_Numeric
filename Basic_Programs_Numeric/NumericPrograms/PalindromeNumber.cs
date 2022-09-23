using System;
using System.Collections.Generic;
using System.Text;

namespace NumericPrograms
{
    public class PalindromeNumber
    {
        public bool isPalindrome(int num) {
            int temp = num;
            int rev=0;
            while (temp != 0)
            {
                rev *= 10;
                rev += (temp % 10);
                temp /= 10;
            }
            return (rev == num) ? true: false;
        }
    }
}
