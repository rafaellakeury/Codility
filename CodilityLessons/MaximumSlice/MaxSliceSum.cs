using System;
using System.Linq;

namespace CodilityLessons.MaximumSlice
{
    public class MaxSliceSum
    {
        public int Solution(int[] A)
        {
            int maxGlobal = A[0];
            int maxLocal = A[0];

            for(int j = 1; j < A.Count(); j++)
            {
                maxLocal = Math.Max(A[j], maxLocal + A[j]);
                maxGlobal = Math.Max(maxGlobal, maxLocal);
            }
            return maxGlobal;
        }
    }
}