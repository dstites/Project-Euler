using System.Collections.Generic;

namespace Problems
{
    class Problem14 : BaseProblem
    {
        public override int ProblemId
        {
            get { return 14; }
        }

        private Dictionary<long, int> _list = new Dictionary<long, int> { { 1, 1 } };

        private int GetLength(long value)
        {
            int length;
            var valExists = _list.TryGetValue(value, out length);
            return !valExists ? GetLength(value%2 == 0 ? value/2 : (value*3) + 1) + 1 : length;
        }

        public override string DoProblem()
        {
            var longestChainId = 0;
            var longestChain = 0;
            for (var i = 2; i < 1000000; i++ )
            {
                var length = GetLength(i);
                _list.Add(i, length);
                if (length <= longestChain) continue;
                longestChain = length;
                longestChainId = i;
            }
            return longestChainId.ToString();
        }
    }
}
