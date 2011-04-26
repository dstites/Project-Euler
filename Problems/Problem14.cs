using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problems
{
    class Problem14 : BaseProblem
    {
        public override int ProblemId
        {
            get { return 14; }
        }

        public override string DoProblem()
        {
            var longestChain = 0;
            var longestChainId = 0;
            for (var i = 1000000; i > 1; i-- )
            {
                var list = new List<int>();
                var x = i;
                while (x > 1)
                {
                    list.Add(x);
                    if (x % 2== 0)
                    {
                        x /= 2;
                    }else
                    {
                        x = (3 * x) + 1;
                    }
                }
                if (list.Count <= longestChain) continue;
                longestChain = list.Count;
                longestChainId = i;
            }
            return longestChainId.ToString();
        }
    }
}
