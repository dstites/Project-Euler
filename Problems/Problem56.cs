using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Problems
{
    class Problem56 : BaseProblem
    {
        public override int ProblemId
        {
            get { return 56; }
        }

        private static int Sum(BigInteger result)
        {
            return result.ToString().ToCharArray().Sum(q => Convert.ToInt16(q) - 48);
        }

        public override string DoProblem()
        {
            var maximumSum = 0;
            for(var a=90; a < 100; a++){
	            for(var b =90; b < 100; b++){
		            var result = Utilities.Power(a, b);
		            var sum = Sum(result);
			        if (sum > maximumSum ){
				        maximumSum = sum;
			        }
	            }
            }
            return maximumSum.ToString();
        }
    }
}
