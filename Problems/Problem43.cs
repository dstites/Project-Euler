using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public class Problem43 : BaseProblem
    {
        #region implemented abstract members of Problems.BaseProblem
        public override string DoProblem()
        {
            var permutations = new List<string>();
            var firstAndSecondDigits = new List<int> { 1, 4};
            var thirdAndFourthDigits = new List<int> { 0, 6, 3 };
            foreach (var a in firstAndSecondDigits)
            {
                foreach (var b in firstAndSecondDigits)
                {
                    if (a == b)
                        continue;
                    foreach (var c in thirdAndFourthDigits)
                    {
                        foreach (var d in thirdAndFourthDigits)
                        {
                            if ((d == 3 && c == 6) || (c == 3 && d == 6) || (c == 0 && d == 3))
                                continue;
                            
                            if (c == 6 || d == 6){
                                const int e = 357289;
                                var format1 = String.Format("{0}{1}{2}{3}{4}", a, b, c, d, e);

                                var format1NumbersCount = format1.ToCharArray().Distinct().Count();
                                if (format1NumbersCount == 10)
                                {
                                    permutations.Add(format1);
                                }
                            }
                            else if (c == 3)
                            {
                                const int f = 952867;
                                var format2 = String.Format("{0}{1}{2}{3}{4}", a, b, c, d, f);
                                var format2NumbersCount = format2.ToCharArray().Distinct().Count();
                                if (format2NumbersCount == 10)
                                {
                                    permutations.Add(format2);
                                }
                            }
                        }
                    }
                }
            }


            return permutations.Sum(q => Convert.ToInt64(q)).ToString();
        }


        public override int ProblemId
        {
            get
            {
                return 43;
            }
        }

        #endregion
    }
}

