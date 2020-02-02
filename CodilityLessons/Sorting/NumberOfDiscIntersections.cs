using System;

namespace CodilityLessons.Sorting
{
	public class NumberOfDiscIntersections
	{
		public int Solution(int[] A)
		{
            int numberOfIntersections = 0;
            int openDiscs = 0;
            long[] startingPoints = new long[A.Length];
            long[] endingPoints = new long[A.Length];

            for(long i = 0; i<A.Length; i++) 
            {
                startingPoints[i] = i - A[i];
                endingPoints[i] = i + A[i];
            }
            Array.Sort(startingPoints);
            Array.Sort(endingPoints);
            long currentStartIndex = 0;
            long currentEndIndex = 0;
            while(currentStartIndex < A.Length)
            {
                if (numberOfIntersections > 10000000) return -1;
                if(startingPoints[currentStartIndex] <= endingPoints[currentEndIndex])
                {
                    numberOfIntersections += openDiscs;
                    openDiscs++;
                    currentStartIndex++;
                }
                else
                {
                    openDiscs--;
                    currentEndIndex++;
                }
            }
            return numberOfIntersections;
        }
    }
}