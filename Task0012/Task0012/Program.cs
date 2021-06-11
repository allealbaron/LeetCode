using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Task0012
{
    public class Program
    {
        private static readonly Dictionary<int, string> RomanNumbers = new()
        {
            { 1, "I" },
            { 4, "IV" },
            { 5, "V" },
            { 9, "IX" },
            { 10, "X" },
            { 40, "XL" },
            { 50, "L" },
            { 90, "XC" },
            { 100, "C" },
            { 400, "CD" },
            { 500, "D" },
            { 900, "CM" },
            { 1000, "M"}
        };

        static void Main()
        {
            Console.WriteLine("Hello World!");
        }

        static public string IntToRoman(int num) 
        {
            StringBuilder result = new();

            foreach (var element in RomanNumbers.OrderByDescending(p => p.Key))
            {
                while (num - element.Key >= 0)
                {
                    result.Append(element.Value);
                    num -= element.Key;
                }
            }                     

            return result.ToString();
        }
    }
}
