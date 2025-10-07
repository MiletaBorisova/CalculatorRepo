using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class OptionsManager
    {
        public static string[] OptionsList = {
            "ex - Exit",
            "a - Add",
            "s - Subtract",
            "m - Multiply",
            "pow - Power",
            "log - Logarithm",
            "fact - Sum of 2 factorials"
                
             };

        public static string Add(double a, double b)
        {
            return $"{a} + {b} = {a + b}";
        }

        public static string Multiply(double a, double b)
        {
            return $"{a} x {b} = {a * b}";
        }

        public static string Subtract(double a, double b)
        {
            return $"{a} - {b} = {a - b}";
        }
        public static void Power(double a, double b)
        {
            Console.WriteLine($"{a} ^ {b} = {Math.Pow(a, b)}");
        }
        public static void Log(double a, double b)
        {
            Console.WriteLine($"Log of {a} with base {b} = {Math.Log(a, b)}");
        }
        public static void Factorial(double a, double b)
        {
            long factA = CalculateFact((int)a);
            long factB = CalculateFact((int)b);
            Console.WriteLine($"{a}! + {b}! = {(int)a}! + {(int)b}! = {factA + factB}");
        }
        private static long CalculateFact(int a)
        {
            long result = a;
            for (int i = a - 1; i >= 1; i--)
            {
                result = result * i;
            }
            return result;
        }

    }
}
