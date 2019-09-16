using System;

namespace CodilityLessons.PrefixSums
{
	public class MinimumAverageTwoSlice
	{
		public int Solution(int[] A)
		{
			var smallestIndex = 0;
			double smallestValue = Int32.MaxValue;
			for (int i = 0; i< A.Length-1; i++)
			{
				double smallestSliceOfTheIndex = Int32.MaxValue;
				var denominatorCount = 2;
				var accumulatedValue = A[i];
				for(int j = i+1; j< A.Length; j++)
				{
					accumulatedValue += A[j];
					double division = (double) accumulatedValue / denominatorCount;
					if(division < smallestSliceOfTheIndex)
					{
						smallestSliceOfTheIndex = division;
					}
					denominatorCount++;
				}
				if(smallestSliceOfTheIndex < smallestValue)
				{
					smallestIndex = i;
					smallestValue = smallestSliceOfTheIndex;
				}
			}
			return smallestIndex;
		}

		public int Solution2(int[] A)
		{
			var result = 0;
			double smallestValue = Int32.MaxValue;
			double currentAvg;
			for(int i  = 0; i < A.Length-2; i++)
			{
				currentAvg = (double) A[i] + A[i + 1] / 2;
				if (currentAvg < smallestValue)
				{
					result = i;
					smallestValue = currentAvg;
				}

				currentAvg = (double) A[i] + A[i + 1] + A[i + 2] / 3;
				if (currentAvg < smallestValue)
				{
					result = i;
					smallestValue = currentAvg;
				}
			}
			currentAvg = (double)(A[A.Length - 2] + A[A.Length - 1]) / 2;
			if(currentAvg < smallestValue)
			{
				result = A.Length - 2;
				smallestValue = currentAvg;
			}
			return result;
		}

		public int Solution3(int[] A)
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
				int i0 = i;
				int i1 = i + 1;
				double avg2 = (double) (sums[i1 + 1] - sums[i0]) / 2.0f;

				if (avg2 < smallestValue)
				{
					smallestValue = avg2;
					minSliceIndex = i;
				}

				if (i < N - 2)
				{
					int i2 = i + 2;
					float avg3 = (sums[i2 + 1] - sums[i0]) / 3.0f;

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