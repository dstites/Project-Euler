using System;
using System.Linq;
using System.Numerics;

namespace Problems
{
    class Problem16 : BaseProblem
    {
        public override int ProblemId
        {
            get { return 16; }
        }

        public override string DoProblem()
        {
            BigInteger number = (BigInteger)Math.Pow(2, 1000);
            var numberString = number.ToString();
            var sum = numberString.Sum(t => Convert.ToInt16(t) - 48);
            return sum.ToString();
        }
    }
}
