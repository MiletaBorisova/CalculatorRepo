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
            "dr - Devide Remainder"
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

        public static void DevideRemainder(double a, double b)
        {
            Console.WriteLine($"{a} % {b} = {a % b}");
        }

    }
}
