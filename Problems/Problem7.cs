using System.Collections;
using System.Collections.Generic;

namespace Problems
{
    public class Problem7 : BaseProblem
    {
        public override int ProblemId
        {
            get { return 7; }
        }

        public override string DoProblem()
        {
            const int max = 150000;
            var primes = new BitArray(max);
            var count = 1;
            var x = 3;
            for ( ; count < 10001; x += 2)
            {
                if (!primes.Get(x))
                {
                    count++;
                } 
                for (int y = 2 * x; y < max; y += x)
                {
                    primes.Set(y, true);
                }
            }
            return x.ToString();
        }
    }
}
