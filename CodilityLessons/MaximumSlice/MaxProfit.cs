using System;
using System.Linq;

namespace CodilityLessons.MaximumSlice
{
    public class MaxProfit
    {
        public int Solution(int[] A)
        {
            int maxGlobal = 0;
            int maxLocal = 0;

            for(int j = 1; j < A.Count(); j++)
            {
                var delta = A[j] - A[j-1];
                maxLocal = Math.Max(delta, maxLocal + delta);
                maxGlobal = Math.Max(maxGlobal, maxLocal);
            }
            return maxGlobal;
        }
    }
}