using System.Collections.Generic;

namespace Problems
{
    class Problem15 : BaseProblem
    {
        public override int ProblemId
        {
            get { return 15; }
        }

        public override string DoProblem()
        {
            return Utilities.PascalEntry(2*20, 20).ToString();
        }
    }
}
