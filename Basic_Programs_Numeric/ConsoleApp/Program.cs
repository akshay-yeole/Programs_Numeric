using NumericPrograms;
using System;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            do
            {
                CommonCode.performOperation(CommonCode.Menu());
            } while (CommonCode.isContinue() != "N");
            CommonCode.TheEnd();
        }
    }
}
