﻿using System;
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
            Console.WriteLine("06. HFC And LCM  --Pending");
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
                        AddDigitsUsingRecursion obj1 = new AddDigitsUsingRecursion();
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
                    //using conditional operator
                    Console.WriteLine($"Number {userInput} is :: {obj4.usingConditionalOperator(userInput)}");
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