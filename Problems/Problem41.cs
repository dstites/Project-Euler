using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problems
{
    class Problem41 : BaseProblem
    {
        public override int ProblemId
        {
            get { return 41; }
        }

        private bool IsPandigital(int prime)
        {
            var primeString = prime.ToString();
            var flag = true;
            for (int i = 1; i <= primeString.Length; i++)
            {
                if (primeString.Count(q => q == i.ToString()[0]) == 1)
                {
                    continue;
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        public override string DoProblem()
        {
            //var num = 0;
            //var primes = Utilities.ESieve(987654321);
            //foreach (var prime in primes.Reverse())
            //{
            //    if (IsPandigital(prime))
            //    {
            //        num =  prime;
            //        break;
            //    }
            //}
            //return num.ToString();
            return "COMPLETE";
        }
    }
}
