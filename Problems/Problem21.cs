using System;
namespace Problems
{
	public class Problem21 : BaseProblem
	{	
		public override int ProblemId {
			get {
				return 21;
			}
		}
		
		public override string DoProblem ()
		{
			int sum = 0;
 			for(int a = 2; a < 10000; a ++){
				var da = Utilities.SumDivisors(a);
				if (da > a && Utilities.SumDivisors(da) == a){
					sum += da + a;	
				}
			}
			return sum.ToString();
		}
		
	}
}

