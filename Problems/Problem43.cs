using System;
namespace Problems
{
	public class Problem43 : BaseProblem
	{
		#region implemented abstract members of Problems.BaseProblem
		public override string DoProblem ()
		{
			var permutations = new List<string>();
			int f = 5;
			var fourthDigits = new List<int>{ 0,4,6 };
			for(int a = 0; a <= 6; a++){
				for(int b = 0; b <= 6; b++){
					if (a == b)
						continue;
					for(int c = 0; c <= 6; c++){
						if (a == c || b == c)
							continue;
						foreach(var d in fourthDigits){
							if (a == d || b == d || c == d)
								continue;
							
							var e = 357289;
							
							var format1 = String.Format("{0}{1}{2}{3}{4}", a, b, c, d, e);
							
							var format1NumbersCount = format1.ToCharArray().Distinct().Count();
							if (format1NumbersCount == 10)
							{
								permutations.Add(format1);	
							}else{
								var f = 952867;
								var format2 = String.Format("{0}{1}{2}{3}{4}", a, b, c, d, f);
								var format2NumbersCount = format2.ToCharArray().Distinct().Count();
								if (format2NumbersCount == 10){
										
								}
							}
							
							permutations.Add();
											}
										}
									}
								}
							}
						}
						
					}
				}
			}
			return string.Empty;
		}
		
		
		public override int ProblemId {
			get {
				return 43;
			}
		}
		
		#endregion
	}
}

