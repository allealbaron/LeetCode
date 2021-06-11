using System.Linq;

namespace Task258
{
    public class Program
    {
        static void Main()
        {
        }

        /// <summary>
        /// Given a number, sums all digits until 
        /// result has only one digit
        /// </summary>
        /// <param name="num">num</param>
        /// <returns>Final number</returns>
        static public int AddDigits(int num)
        {
            int result = num;

            while (result >= 10)
            {
                int acc = 0;

                while (result > 0)
                {
                    acc += result % 10;
                    result /= 10;
                }

                result = acc;

            }

            return result;

        }

    }
}
