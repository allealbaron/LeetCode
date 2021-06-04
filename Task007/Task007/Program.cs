using System;
using System.Linq;
using System.Text;

namespace Task007
{
    public class Program
    {
        static void Main()
        {
        }

        static public int Reverse(int x)
        {
            int sign = 1;
            if (x < 0)
            {
                sign = -1;
                try
                {
                    x = System.Math.Abs(x);
                }
                catch (Exception e)
                {
                    return 0;
                }
            }

            char[] number = x.ToString().ToArray<char>();

            StringBuilder s = new StringBuilder();

            for (int i = number.Length- 1; i >= 0; i--)
            {
                s.Append(number[i]);
            }

            if (int.TryParse(s.ToString(), out int result))
            {
                return result * sign;
            }
            else
            {
                return 0;
            }

        }

    }
}
