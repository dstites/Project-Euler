using System;
using System.Linq;

namespace Problems
{
    public class Problem5:BaseProblem
    {
        public override int ProblemId
        {
            get { return 5; }
        }

        public override string DoProblem()
        {
            var factors = new[]{ 2,2,2,2,3,3,5,7,11,13,17,19};
            var answer = factors.Aggregate(1, (current, factor) => current*factor);
            return (answer).ToString();
        }
    }
}
