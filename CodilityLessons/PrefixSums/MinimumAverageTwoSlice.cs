using System;

namespace CodilityLessons.PrefixSums
{
	public class MinimumAverageTwoSlice
	{
		//4, 2, 2, 5,1, 5, 8
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
	}
}
