using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
namespace Problems
{
	public class Problem26 : BaseProblem
	{
		#region implemented abstract members of Problems.BaseProblem
		public override string DoProblem ()
		{
			// 1/d has a cycle of n digits if 10n−1 mod d = 0 for prime d.
			var primes = Utilities.ESieve (1000);
			var p = 0;
			for (p = primes.Length - 1; p > 1; p--) {
				var n = primes[p];
//				var c = n - 1;
//				if ((((BigInteger)Math.Pow (10, c) - 1) % n) == 0)
//					break;
//				
//			}
				var d = 1;
				var count = 0;
				var d0 = d % n;
				d = (d % n) * 10;
				
				for (count = 0; count <= n; ++count) {
					if (d >= n)
						d %= n;
					if (d == d0)
						break;
					d *= 10;
				}
				if (count +2 == n)
					return n.ToString ();
			}
			
			return string.Empty;
		}


		public override int ProblemId {
			get { return 26; }
		}
		
		#endregion
		
	}
}

