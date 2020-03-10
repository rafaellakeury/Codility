using System;

namespace CodilityLessons.PrefixSums
{
	public class MinimumAverageTwoSlice
	{
		public int Solution(int[] A)
		{
			int minSliceIndex = 0;
			int N = A.Length;
			int[] sums = new int[N + 1];
			double smallestValue = Int32.MaxValue;

			for (int i = 0; i< N; i++)
			{
				sums[i + 1] = sums[i] + A[i];
			}

			for (int i = 0; i < N - 1; i++)
			{
				int i2 = i + 2;
				double avg2 = (double) (sums[i2] - sums[i]) / 2.0f;

				if (avg2 < smallestValue)
				{
					smallestValue = avg2;
					minSliceIndex = i;
				}

				if (i < N - 2)
				{
					int i3 = i + 3;
					float avg3 = (sums[i3] - sums[i]) / 3.0f;

					if (avg3 < smallestValue)
					{
						smallestValue = avg3;
						minSliceIndex = i;
					}
				}
			}

			return minSliceIndex;
		}
	}
}