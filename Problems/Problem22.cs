using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Problems
{
    class Problem22 : BaseProblem
    {
        public override int ProblemId
        {
            get { return 22; }
        }

        public override string DoProblem()
        {
            //var total = 0;
            //var names = File.ReadAllText("names.txt").Split(',').OrderBy(q => q);
            //for (int i = 0; i < names.Count(); i++)
            //{
            //    var name = names.ElementAt(i).Replace("\"", "");
            //    var sum = name.ToCharArray().Sum(q => Convert.ToInt16(q) - 64);
            //    total += (i + 1) * sum;
            //}
            //return total.ToString();
            return "COMPLETE";
        }
    }
}
