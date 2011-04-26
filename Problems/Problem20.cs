using System;
using System.Linq;
using System.Numerics;

namespace Problems
{
    class Problem20 : BaseProblem
    {
        public override int ProblemId
        {
            get { return 20; }
        }

        public override string DoProblem()
        {
            BigInteger product = 1;
            for (int i = 100; i > 1; i--)
            {
                product *= i;
            }
            var sum = product.ToString().Sum(q=> Convert.ToInt16(q) - 48);
            return sum.ToString();
        }
    }
}
