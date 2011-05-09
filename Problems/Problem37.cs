using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problems
{
    class Problem37 : BaseProblem
    {
        public override int ProblemId
        {
            get { return 37; }
        }

        private bool TruncatePrimeRight(int prime)
        {
            var flag = false;
            var primeString = prime.ToString();
            var rtl = Convert.ToInt32(primeString.Substring(1));
            
            if (primes.Contains(rtl))
            {
                flag = true;
            }
            if (flag && rtl > 10)
            {
                flag = TruncatePrimeRight(rtl);
            }
            return flag;
        }

        private bool TruncatePrimeLeft(int prime)
        {
            var flag = false;
            var ltr = prime / 10;

            if (primes.Contains(ltr))
            {
                flag = true;
            }
            if (flag && ltr > 10)
            {
                flag = TruncatePrimeLeft(ltr);
            }
            return flag;
        }

        private List<int> primes = Utilities.ESieve(1000000).ToList();

        public override string DoProblem()
        {
            //var count = 0;
            //var sum = 0;
            //foreach (var prime in primes.Where(q => q > 10))
            //{
            //    if (TruncatePrimeRight(prime) && TruncatePrimeLeft(prime))
            //    {
            //        count ++;
            //        sum += prime;
            //    }
            //    if (count == 11)
            //        break;
            //}
            //return sum.ToString();
            return "COMPLETE";
        }
    }
}
