using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    //  A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91  99.
    //  Find the largest palindrome made from the product of two 3-digit numbers.
    public class Problem4 : BaseProblem
    {
        public override int ProblemId
        {
            get { return 4; }
        }
        
        public override string DoProblem()
        {
            var products = new List<int>();
            var answer = 0;
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    var product = i*j;
                    if (product % 10 != 0)
                    {
                        if (Utilities.IsPalindrome(product.ToString()) && product > answer)
                        {
                            answer = product;
                        }
                    }
                }
            }
            return answer.ToString();
        }
    }
}
