using System;
using System.Linq;

namespace CodilityLessons.Sorting
{
	public class Triangle
	{
		public int Solution(int[] A)
		{
			if (A.Count() < 3 || A == null)
				return 0;
			Array.Sort(A);
			for(int i=0; i<A.Length-2;i++)
			{
				if (A[i] >= 0 && A[i] > A[i + 2] - A[i + 1])
					return 1;
			}
			return 0;
		}
	}
}
