using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    class Problem10 : BaseProblem
    {
        public override int ProblemId
        {
            get { return 10; }
        }

        public override string DoProblem()
        {
            const int max = 2000000;
            var primes = new Dictionary<long, bool>(max);
            for(var i = 3; i < max; i+= 2)
            {
                primes.Add(i, false);
            }
            long y = 3;
            while(y < 1414)
            {
                for (long p = y*y; p < max; p += y)
                {
                    primes[p] = true;
                }
                long y1 = y;
                y = primes.First(q => !q.Value && q.Key > y1).Key;
            }
            return (2 + primes.Where(q=> !q.Value).Select(q=> q.Key).Sum()).ToString();
        }
    }
}
