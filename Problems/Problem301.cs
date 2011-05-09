using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Problems
{
    class Problem301 : BaseProblem
    {
        public override int ProblemId
        {
            get { return 301; }
        }

        public override string DoProblem()
        {
            int sum = 0;
            for (int i = 1; i <= (1 << 30); i++) if ((i ^ (2 * i) ^ (3 * i)) == 0) sum++;
            return sum.ToString();
        }
    }
}
