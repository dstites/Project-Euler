using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problems
{
    class Problem19 : BaseProblem
    {
        public override int ProblemId
        {
            get { return 19; }
        }

        public override string DoProblem()
        {
            var count = 0;
            for (int year = 1901; year <= 2000; year++)
            {
                for (int month = 1; month <= 12; month++)
                {
                    DateTime date = new DateTime(year, month, 1);
                    if (date.DayOfWeek == DayOfWeek.Sunday)
                    {
                        count++;
                    }
                }
            }
            return count.ToString();
        }
    }
}
