using System;
using System.Collections.Generic;
using System.Linq;
namespace Problems
{
	public class Problem38 : BaseProblem
	{
		#region implemented abstract members of Problems.BaseProblem
		public override string DoProblem ()
		{
			for(int a = 9876; a > 9123; a--){
				var product = (a * 1).ToString() + (a * 2).ToString();
				var numbersCount = product.Replace("0", "").ToCharArray().Distinct().Count();
				if (numbersCount == 9){
					return product;
				}
			}
			return string.Empty;
		}
		
		
		public override int ProblemId {
			get {
				return 38;
			}
		}
		#endregion
	}
}

