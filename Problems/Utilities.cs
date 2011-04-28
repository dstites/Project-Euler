using System.Linq;
using System.Numerics;

namespace Problems
{
    public class Utilities
    {
        public static bool IsPalindrome(string testString)
        {
            var reverseString = testString.AsEnumerable().Reverse();
            return new string(reverseString.ToArray()) == testString;
        }

        public static BigInteger Power(double val1, double val2)
        {
            BigInteger result = 1;
            for (int i = 0; i < val2; i++)
            {
                result *= (BigInteger)val1;
            }
            return result;
        }
    }
}
