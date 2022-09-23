using System;
using System.Collections.Generic;
using System.Text;

namespace NumericPrograms
{
    public class LcmAndHcf
    {
        public int getHCF(int a, int b)
        {
            int HCF = 0;
            while (b != 0)
            {
                HCF = b;
                b = a % b;
                a = HCF;
            }
            return HCF;
        }
        public double getLCM(int a, int b)
        {
            int HCF, LCM;
            HCF = getHCF(a, b);
            LCM = (a * b) / HCF;
            return LCM;
        }
        public int getLCMUsingRecursion(int a, int b)
        {
            int HCF, LCM;
            HCF = getHCFUsingRecursion(a, b);
            LCM = (a * b) / HCF;
            return LCM;
        }
        public int getHCFUsingRecursion(int a, int b)
        {
            if (b == 0)
                return a;
            return getHCFUsingRecursion(b, a % b);
        }
    }
}
