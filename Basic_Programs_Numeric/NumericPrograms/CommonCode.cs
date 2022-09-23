using System;
using System.Collections.Generic;
using System.Text;

namespace NumericPrograms
{
    public static class CommonCode
    {
        private static int userInput2;

        public static int readInput()
        {
            Console.Write("Enter Numer :: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        public static int Menu()
        {
            Console.WriteLine("-------------------Numeric Programs----------------------");
            Console.WriteLine("01. Add Digits Using Recursion");
            Console.WriteLine("02. Factorial Number");
            Console.WriteLine("03. Factorial Number Using Recursion");
            Console.WriteLine("04. Odd Or Even");
            Console.WriteLine("05. Arithmetic Ops");
            Console.WriteLine("06. Leap Year");
            Console.WriteLine("07. HFC And LCM");
            Console.WriteLine("08. Decimal To Binary");
            Console.WriteLine("09. Addition of N Number");
            Console.WriteLine("10. Swapping of Two Numbers");
            Console.WriteLine("11. Reverse Number");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Enter Choice :: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static bool validateNumber(int num)
        {
            return (num > 0) ? true : false;
        }

        public static void performOperation(int userChoice)
        {
            int userInput;
            int userOutput;
            switch (userChoice)
            {
                case 1:
                    userInput = CommonCode.readInput();
                    if (CommonCode.validateNumber(userInput))
                    {
                        AddDigits obj1 = new AddDigits();
                        userOutput = obj1.addDigits(userInput);
                        Console.WriteLine($"\ntotal of digits :: {userOutput}");
                    }
                    else
                    {
                        Console.WriteLine("You have entered incorrect number.");
                    }

                    break;
                case 2:
                    userInput = CommonCode.readInput();
                    FactorialUsingForLoop obj2 = new FactorialUsingForLoop();
                    Console.WriteLine($"Factorial of {userInput} is :: {obj2.getFactorial(userInput)}");
                    break;
                case 3:
                    userInput = CommonCode.readInput();
                    FactorialUsingRecusion obj3 = new FactorialUsingRecusion();
                    Console.WriteLine($"Factorial of {userInput} is :: {obj3.getFactorial(userInput)}");
                    break;
                case 4:
                    userInput = CommonCode.readInput();
                    OddOrEven obj4 = new OddOrEven();
                    Console.WriteLine($"Number {userInput} is :: {obj4.usingBitWiseOperator(userInput)}");
                    Console.WriteLine($"using conditional operator Number {userInput} is :: {obj4.usingConditionalOperator(userInput)}");
                    break;
                case 5:
                    userInput = CommonCode.readInput();
                    userInput2 = CommonCode.readInput();
                    ArithmeticOps obj5 = new ArithmeticOps();
                    Console.WriteLine($"Addition ::{obj5.Add(userInput, userInput2)}");
                    Console.WriteLine($"Substraction ::{obj5.Sub(userInput, userInput2)}");
                    Console.WriteLine($"Division ::{obj5.Div(userInput, userInput2)}");
                    Console.WriteLine($"Multiplication ::{obj5.Mul(userInput, userInput2)}");
                    break;
                case 6:
                    userInput = CommonCode.readInput();
                    LeapYear obj6 = new LeapYear();
                    Console.WriteLine($"Year {userInput} :: {obj6.checkLeapYear(userInput)}");
                    break;
                case 7:
                    userInput = CommonCode.readInput();
                    userInput2 = CommonCode.readInput();
                    LcmAndHcf obj7 = new LcmAndHcf();
                    Console.WriteLine($"HCF ({userInput}, {userInput2}) is {obj7.getHCF(userInput, userInput2)}");
                    Console.WriteLine($"LCM ({userInput}, {userInput2}) is {obj7.getLCM(userInput, userInput2)}");

                    Console.WriteLine($"Using Recursion HCF ({userInput}, {userInput2}) is {obj7.getHCFUsingRecursion(userInput, userInput2)}");
                    Console.WriteLine($"Using Recursion LCM ({userInput}, {userInput2}) is {obj7.getLCMUsingRecursion(userInput, userInput2)}");
                    break;
                case 8:
                    DecimalToBinary obj8 = new DecimalToBinary();
                    userInput = CommonCode.readInput();
                    Console.WriteLine($"Binary for {userInput} is {obj8.getBinary(userInput)}");
                    break;
                case 9:
                    AddNNumber obj9 = new AddNNumber();
                    userInput = CommonCode.readInput();
                    Console.WriteLine($"Addition for {userInput} is {obj9.getAdditionOfNum(userInput)}");
                    break;
                case 10:
                    userInput = CommonCode.readInput();
                    userInput2 = CommonCode.readInput();
                    SwappingNumber obj10 = new SwappingNumber();

                    Console.WriteLine($"Before Swap : {userInput} {userInput2}");

                    //Using Call By Value
                    //Console.WriteLine($"After Swapped : {obj10.getSwapedNumbers(userInput, userInput2)}");

                    //Using Call By Reference
                    //obj10.getSwapedNumbersUsingReferenceVal(ref userInput, ref userInput2);

                    //Swap by using Bitwise
                    obj10.usingBitwise(ref userInput, ref userInput2);

                    Console.WriteLine($"After Swap : {userInput} {userInput2}");
                    break;
                case 11:
                    ReverseNumber obj11 = new ReverseNumber();
                    userInput = CommonCode.readInput();
                    Console.WriteLine($"Reverse Number :: {obj11.getReverseNumber(userInput)}");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
        public static void TheEnd()
        {
            Console.WriteLine("!!! Press Any Key To Exit !!!");
            Console.ReadLine();
        }

        public static string isContinue()
        {
            Console.WriteLine("do youwant to continue ? (Y|N)");
            return Console.ReadLine().ToUpper();
        }
    }
}
