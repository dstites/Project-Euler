using System;
using System.Linq;
using System.Collections.Generic;
namespace Problems
{
	public class Problem24 : BaseProblem
	{
		#region implemented abstract members of Problems.BaseProblem
		public override string DoProblem ()
		{
//			var permutations = new List<string>();
//			for(int a = 0; a <= 9; a++){
//				for(int b = 0; b <= 9; b++){
//					if (a == b)
//						continue;
//					for(int c = 0; c <= 9; c++){
//						if (a == c || b == c)
//							continue;
//						for(int d = 0; d <= 9; d++){
//							if (a == d || b == d || c == d)
//								continue;
//							for(int e = 0; e <= 9; e++){
//								if (a == e || b == e || c == e || d == e)
//									continue;
//								for(int f = 0; f <= 9; f++){
//									if (a == f || b == f || c == f || d == f || e == f)
//										continue;
//									for(int g = 0; g <= 9; g ++){
//										if (a == g || b == g || c == g || d == g || e == g || f == g)
//											continue;
//										for(int h = 0; h <= 9; h++){
//											if (a == h || b == h || c == h || d == h || e == h || f == h || g == h)
//												continue;
//											for(int i = 0; i <= 9; i++){
//												if (a == i || b == i || c == i || d == i || e == i || f == i || g == i || h == i)
//													continue;
//												for(int j = 0; j <= 9; j++){
//													if (a == j || b == j || c == j || d == j || e == j || f == j || g == j || h == j || i == j)
//														continue;
//													permutations.Add(String.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}", a, b, c, d, e, f, g, h, i, j));
//													if (permutations.Count == 1000000)
//														return permutations[999999];
//												}
//											}
//										}
//									}
//								}
//							}
//						}
//						
//					}
//				}
//			}
			return "COMPLETE";
		}
		
		
		public override int ProblemId {
			get {
				return 24;
			}
		}
		
		#endregion
	}
}

