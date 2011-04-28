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

        private Dictionary<Dictionary<int, int>, int> _list = new Dictionary<Dictionary<int, int>, int>();

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

            return MakeMove(x - 1, y) + MakeMove(x, y - 1);
        }

        public override string DoProblem()
        {
            return string.Empty;
            //return MakeMove(20, 20).ToString();
        }
    }
}
