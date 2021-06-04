using System;
using System.Text.RegularExpressions;

namespace Task008
{
    public class Program
    {
        static void Main()
        {
        }

        /// <summary>
        /// Returns s as an int
        /// </summary>
        /// <param name="s">Number as a string</param>
        /// <returns>Number as an int</returns>
        public static int MyAtoi(string s)
        {
            int result = 0;

            Regex regexLine = new Regex(@"^[\s]*(?<Number>[+-]?[0-9]+)");

            Match resultMatch = regexLine.Match(s);

            if (resultMatch.Success)
            {
                string number = resultMatch.Groups["Number"].Captures[0].Value.Trim();

                if (!(int.TryParse(number, out result)))
                {
                    if (number.Contains("-"))
                    {
                        return int.MinValue;
                    }
                    else
                    {
                        return int.MaxValue;
                    }
                }
                return result;
            }
            else
            {
                return result;
            }

        }
    }
}
