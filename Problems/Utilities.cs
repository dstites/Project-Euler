using System.Linq;

namespace Problems
{
    public class Utilities
    {
        public static bool IsPalindrome(string testString)
        {
            var reverseString = testString.AsEnumerable().Reverse();
            return new string(reverseString.ToArray()) == testString;
        }
    }
}
