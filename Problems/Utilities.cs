using System.Linq;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using System;

namespace Problems
{
    public class Utilities
    {
		
        public static bool IsPalindrome(string testString)
        {
            var reverseString = testString.AsEnumerable().Reverse();
            return new string(reverseString.ToArray()) == testString;
        }

        public static long PascalEntry(int row, int column)
        {
            long current = 1;
            for (int i = 1; i <= column; i++)
            {
                current = (current*(row + 1 - i))/i;
            }
            return current;
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
		
		public static int SumDivisors(int n){
			var sum = 1;
  			var t = Math.Sqrt(n);
			for (int i = 2; i < (int)t + 1; i ++){
				if (n % i == 0){
					sum += i + n/i;
				}
			}
			if (t == (int)t){
				sum -= (int)t;	
			}
			return sum;
		}


        public static int[] ESieve(int upperLimit)
        {
            int sieveBound = (int)(upperLimit - 1) / 2;
            int upperSqrt = ((int)Math.Sqrt(upperLimit) - 1) / 2;

            BitArray PrimeBits = new BitArray(sieveBound + 1, true);

            for (int i = 1; i <= upperSqrt; i++)
            {
                if (PrimeBits.Get(i))
                {
                    for (int j = i * 2 * (i + 1); j <= sieveBound; j += 2 * i + 1)
                    {
                        PrimeBits.Set(j, false);
                    }
                }
            }

            List<int> numbers = new List<int>((int)(upperLimit / (Math.Log(upperLimit) - 1.08366)));
            numbers.Add(2);

            for (int i = 1; i <= sieveBound; i++)
            {
                if (PrimeBits.Get(i))
                {
                    numbers.Add(2 * i + 1);
                }
            }

            return numbers.ToArray();
        }
    }
}
