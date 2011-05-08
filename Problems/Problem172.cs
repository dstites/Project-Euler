using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problems
{
    class Problem172 : BaseProblem
    {
        public override int ProblemId
        {
            get { return 172; }
        }

        public override string DoProblem()
        {
            long count = 0;
            var min = (long)Math.Pow(10, 17);
            var max = (long)Math.Pow(10, 18);
            for (long i = min; i < max; i++)
            {
                var numbers = i.ToString().ToCharArray();
                var flag = true;
                foreach (var item in numbers.Distinct())
                {
                    if (numbers.Count(q => q == item) > 3)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    count++;
                }
            }
            return count.ToString();
        }
    }
}
