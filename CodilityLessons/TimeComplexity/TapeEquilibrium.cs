using System;
using System.Linq;

namespace CodilityLessons.TimeComplexity
{
	class TapeEquilibrium
	{
		public int Solution(int[] A)
		{
			long lower = 0, diff = 0, higher = A.Sum(), minDiff = Int64.MaxValue;
			for (int i = 0; i < A.Length - 1; i++)
			{
				lower += A[i];
				higher -= A[i];
				diff = Math.Abs(higher - lower);
				if (diff < minDiff)
				{
					minDiff = diff;
				}
			}
			return (int)minDiff;
		}
	}
}