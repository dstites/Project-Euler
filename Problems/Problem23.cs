using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
namespace Problems
{
	public class Problem23 : BaseProblem
	{
		#region implemented abstract members of Problems.BaseProblem
		public override string DoProblem ()
		{
			int result = 0;
			int[] numbers = new int[20161];
			ArrayList abundants = new ArrayList();
	 
			for( int i=0; i<numbers.Count(); i++ )
			{
				numbers[i] = i+1;
	 
				result += numbers[i];
	 
				if( isAbundant(numbers[i]) )
				{
					abundants.Add( numbers[i] );
				}
			}
	 
			for( int i=0; i<abundants.Count; i++ )
			{
				for( int j=i; j<abundants.Count; j++ )
				{
					int index = (int)abundants[i] + (int)abundants[j] - 1;
	 
					if( index < numbers.Count() )
					{
						result -= numbers[index];
						numbers[index] = 0;
					}
				}
			}
			return result.ToString();
		}
		
		public static bool isAbundant( int n )
		{
			int sum = 0;
	 
			for( int i=1; i<n; i++ )
			{
				if( n%i == 0 )
				{
					sum += i;
				}
			}
	 
			if( sum > n )
			{
				return true;
			}
	 
			return false;
		}
		
		public override int ProblemId {
			get {
				return 23;
			}
		}
		
		#endregion
		
	}
}

