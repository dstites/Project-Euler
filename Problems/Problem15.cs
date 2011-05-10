using System.Collections.Generic;

namespace Problems
{
    class Problem15 : BaseProblem
    {
        public override int ProblemId
        {
            get { return 15; }
        }

        private int _count = 0;
        
        private long MakeMove(int x, int y)
        {

            if (x == 0 && y == 0)
            {
                return 0L;
            }
            if (x == 0 || y == 0)
            {
                return 1L;
            }

            return 1 + MakeMove(x - 1, y) + MakeMove(x, y - 1);
        }

        public override string DoProblem()
        {
            //return MakeMove(20, 20).ToString();
            return "INCOMPLETE";
        }
    }
}
