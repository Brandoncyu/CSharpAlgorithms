using System;
using System.Collections.Generic;

namespace CSharpAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Brute Force
            Console.WriteLine("Write a function called IsFirstCharRepeated " +
                "that takes in a string and returns a bool. The function " +
                "should return true if the first character is repeated " +
                "anywhere else in the string");
            Console.WriteLine(IsFirstCharRepeated("hi"));

            //Recursion
            Console.WriteLine("\nWrite a function called ReverseString that takes " +
                "in a string and returns a string. The function should return " +
                "the string passed in, but in reverse. The function should " +
                "solve the problem using recursion.");
            Console.WriteLine(ReverseString("test"));

            Console.WriteLine("\nWrite a function called GetSumBetweenNumbers " +
                "that takes in an int min and an int max and returns an int. " +
                "The function should get the sum of all the numbers between " +
                "(and including) min and max. The function should " +
                "solve the problem using iteration.");
            Console.WriteLine(GetSumBetweenNumbers(1, 3));

            Console.WriteLine("\nWrite a function called XToTheYPower that " +
                "takes in an int x and an int y, and returns int. The " +
                "function should return x^y. Solve this using recursion, " +
                "don’t use Math.Pow()");
            Console.WriteLine(XToTheYPower(3, 2));

            Console.WriteLine("\nWrite a function called MultiplyList that " +
                "takes in a List<int>. It should return the product of all " +
                "numbers in the list. Solve this problem using iteration.");
            List<int> numberList = new List<int> { 1, 2, 3,4 };    
            Console.WriteLine(MultiplyList(numberList));
            Console.ReadLine();
        }

        public static bool IsFirstCharRepeated(string input)
        {
            return input.ToLower().Substring(1).Contains(input.ToLower()[0]);
        }

        public static string ReverseString(string input, string accumulator = "")
        {
            if (input.Length == 0)
                return accumulator;

            accumulator = input[0].ToString() + accumulator;
            input = input.Substring(1);

            return ReverseString(input, accumulator);
        }

        public static int GetSumBetweenNumbers(int min, int max, int accumulator = 0)
        {
            if (min > max)
                return accumulator;
            return GetSumBetweenNumbers(min+1, max, accumulator + min);
        }

        public static int XToTheYPower(int x, int y, int accumulator = 1)
        {
            if (y == 0)
                return accumulator;
            return XToTheYPower(x, y - 1, accumulator * x);
        }

        public static int MultiplyList(List<int> numberList, int accumulator = 1)
        {
            if (numberList.Count == 0)
                return accumulator;

            int firstInt = numberList[0];
            accumulator *= firstInt;
            numberList.RemoveAt(0);

            return MultiplyList(numberList, accumulator);
        }
    }
}
