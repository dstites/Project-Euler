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

        private int MakeMove(int x, int y)
        {
            var val = new Dictionary<int, int>
                          {
                              {x, y}
                          };
            int count;
            _list.TryGetValue(val, out count);
            if (count == 0)
            {
                if (x < 20)
                {
                    count += MakeMove(x + 1, y);
                }
                if (y < 20)
                {
                    count += MakeMove(x, y + 1);
                }
                _list.Add(val, count);
            }
            
            return count;
        }

        public override string DoProblem()
        {
            return MakeMove(0, 0).ToString();
        }
    }
}
