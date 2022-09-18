using System;
using System.Collections.Generic;
using System.Text;

namespace NumericPrograms
{
    public class LeapYear
    {
        public string checkLeapYear(int userInput)
        {
            return ((userInput % 400 == 0) || (userInput % 100 == 0) || (userInput % 4 == 0)) ? "Leap Year" : "Not Leap Year";
        }
    }
}
