using System;
using System.Collections.Generic;

namespace Problems
{
    class Problem12 : BaseProblem
    {
        public override int ProblemId
        {
            get { return 12; }
        }

        public override string DoProblem()
        {
            var divisors = new List<long>();
            long i = 28;
            for (int k = 7; divisors.Count <= 500; i += k)
            {
                divisors = new List<long>();
                for (int j = 1; j <= Math.Sqrt(i); j++)
                {
                    if (i%j != 0) continue;
                    long dividend = i/j;
                    divisors.Add(j);
                    if (dividend != j)
                    {
                        divisors.Add(dividend);
                    }
                }
                if (divisors.Count > 500)
                {
                    break;
                }
                k++;
            }
            return i.ToString();
        }
    }
}
