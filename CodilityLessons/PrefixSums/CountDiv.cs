using System;

namespace CodilityLessons.PrefixSums
{
	public class CountDiv
	{
		public int Solution(int A, int B, int K)
		{
			var result = 0;
			if (K > B)
			{
				if (B == 0) result = 1;
				return result;
			}

			if(A == B)
			{
				return B % K == 0 ? 1 : 0;
			}

			double rangeToUse = K;
			for(int i = A; i<=B; i++)
			{
				if (i % K == 0)
				{
					rangeToUse = (B - i) + 1;
					break;
				}
			}
			result = rangeToUse > K ? (int) Math.Ceiling(rangeToUse / K) : 1;
			return result;
		}
	}
}
