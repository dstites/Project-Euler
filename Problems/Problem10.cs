using System.Collections;
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
            var primes = new Dictionary<int, bool>(max);
            for(var i = 3; i < max; i+= 2)
            {
                primes.Add(i, false);
            }
            var y = 3;
            var sum = 2;
            while(y < max)
            {
                for (var x = y*y; x < max; x += y)
                {
                    primes[x] = true;
                }
                sum += y;
                y = primes.First(q => !q.Value && q.Key > y).Key;
            }
            return sum.ToString();
        }
    }
}
