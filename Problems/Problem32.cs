using System;
using System.Collections.Generic;
using System.Linq;
namespace Problems
{
	public class Problem32 : BaseProblem
	{
		#region implemented abstract members of Problems.BaseProblem
		public override string DoProblem ()
		{
			var products = new List<int>();
			for(int a = 1; a <= 99; a++){
				for(int b = 100; b <= 9999; b++){
					var product = a * b;
					if (product < 9876){
						var numbers = String.Format("{0}{1}{2}", a, b, product).Replace("0", "");
						var numbersCount = numbers.ToCharArray().Distinct().Count();
						if (numbersCount == 9){
							products.Add(product);
						}
					}
						
				}
			}
			
			var sum = products.Distinct().Sum(q => q);
			return sum.ToString();
		}
		
		
		public override int ProblemId {
			get {
				return 32;
			}
		}
		
		#endregion
	}
}

