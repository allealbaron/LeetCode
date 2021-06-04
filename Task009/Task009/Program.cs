using System.Linq;

namespace Task009
{
    public class Program
    {
        static void Main()
        {
        }

        static public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            else
            {
                var number = x.ToString().ToArray<char>();

                int numberLength = x.ToString().Length;

                for (int i = 0; i < numberLength / 2; i++)
                {

                    if (number[i] != number[numberLength - 1 - i])
                    {
                        return false;
                    }
                }

                return true;
            }

        }

    }
}
