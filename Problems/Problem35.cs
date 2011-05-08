using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Problems
{
    class Problem35 : BaseProblem
    {
        public override int ProblemId
        {
            get { return 35; }
        }

        private List<int> primes = Utilities.ESieve(1000000).ToList();

        private int IsCircular(int prime)
        {
            int multiplier = 1;
            int number = prime;
            int count = 0;
            int d;
 
            //Count the digits and check for even numbers
            while (number > 0) {
                d = number % 10;
                if (d == 5) {
                    primes.Remove(prime);
                        return 0;
                    }
                    number /= 10;
                    multiplier *= 10;
                    count++;
            }
            multiplier /= 10;
 
            //Rotate the number and check if they are prime
            number = prime;
            List<int> foundCircularPrimes = new List<int>();
 
            for (int i = 0; i < count; i++) {
                if(primes.Contains(number)) {
                    foundCircularPrimes.Add(number);
                    primes.Remove(number);
                }else if(!foundCircularPrimes.Contains(number)) {
                    return 0;
                }
 
                d = number % 10;
                number = d * multiplier + number / 10;
            }
 
            return foundCircularPrimes.Count;

        }

        public override string DoProblem()
        {
            var count = 2;
            primes.Remove(2);
            primes.Remove(5);

            while (primes.Count > 0)
            {
                count += IsCircular(primes.Min());
            }

            return count.ToString();
        }
    }
}
