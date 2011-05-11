using System;
using System.Collections.Generic;

namespace Problems
{
    class Problem29 : BaseProblem
    {
        public override int ProblemId
        {
            get { return 29; }
        }

        public override string DoProblem()
        {
            var products = new List<double>();
            for (var a = 2; a <= 100; a++)
            {
                for (var b = 2; b <= 100; b++)
                {
                    var product = Math.Pow(a, b);
                    if (!products.Contains(product))
                    {
                        products.Add(product);
                    }
                }
            }
            return products.Count.ToString();
        }
    }
}
