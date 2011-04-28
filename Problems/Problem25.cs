using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Problems
{
    class Problem25 : BaseProblem
    {
        public override int ProblemId
        {
            get { return 25; }
        }

        public override string DoProblem()
        {
            var digits = 0;
            var fib = new List<BigInteger>()
                          {
                              1,
                              1
                          };
            while(digits < 1000)
            {
                BigInteger x = fib[fib.Count - 1] + fib[fib.Count - 2];
                fib.Add(x);
                digits = x.ToString().ToCharArray().Length;
            }
            return fib.Count.ToString();
        }
    }
}
