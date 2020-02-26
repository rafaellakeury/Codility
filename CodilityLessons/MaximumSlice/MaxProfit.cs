using System;
using System.Collections.Generic;
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
















        public int bla(int[] A)
        {
            var list = A.ToList();
            if(list == null || list.Count <= 1)
                return 0;

            while(list.Count > 1)
            {
                int maxValue = list.Max();
                int minValue = list.Min();
                int maxIndex = list.IndexOf(maxValue);
                int minIndex = list.IndexOf(minValue);

                if(maxIndex > minIndex)
                    return maxValue - minValue;
                else
                {
                    list.RemoveAt(maxIndex);
                    if(minIndex == list.Count)
                        list.RemoveAt(minIndex-1);
                }
            }
            return 0;
        }
    }
}