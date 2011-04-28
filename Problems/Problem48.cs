using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Problems
{
    class Problem48 : BaseProblem
    {
        public override int ProblemId
        {
            get { return 48; }
        }

        public override string DoProblem()
        {
            long result = 1;
            for (int i = 2; i <= 1000; i++)
            {
                long product = 1;
                for (int j = 1; j <= i; j++)
                {
                    product = (product * i) % 100000000000;
                }
                result += product;
            }
            return result.ToString().Substring(result.ToString().Length - 10);
        }
    }
}
