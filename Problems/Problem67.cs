using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Problems
{
    class Problem67 : BaseProblem
    {
        public override int ProblemId
        {
            get { return 67; }
        }
        public override string DoProblem()
        {
            var result = File.ReadAllLines("triangle.txt")
                .Select(q=> q.Split(' ')
                    .Select(i => Convert.ToInt32(i))
                    .ToList()
                ).Aggregate(new List<int> { 0 },
            (currentMaxima, nextRow) =>
            {
                var rowLength = nextRow.Count();
                return nextRow.Select((cell, index) =>
                    index == 0 ? cell + currentMaxima[index]
                    : index == rowLength - 1 ? cell + currentMaxima[index - 1]
                    : Math.Max(cell + currentMaxima[index - 1], cell + currentMaxima[index]))
                    .ToList();
            }).Max();
            return result.ToString();
        }
    }
}
