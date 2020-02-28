using System;
using System.Linq;

namespace CodilityLessons.MaximumSlice
{
    public class MaxDoubleSliceSum
    {
        public int Solution(int[] A)
        {
            // 3, 2, 6, -1, 4, 5, -1, 2
            //N = 8
            //K1 = [0, 2, 8, 7, 11, 16, 15]
            //K2 = [0, 16, 14, 8, 9, 5, 0, 0 ]
            int N = A.Count();
            int[] K1 = new int[N];
            int[] K2 = new int[N];

            for(int i = 1; i < N-1; i++){
                K1[i] = Math.Max(K1[i-1] + A[i], 0);
            }
            for(int i = N-2; i > 0; i--){
                K2[i] = Math.Max(K2[i+1]+A[i], 0);
            }

            int max = 0;

            for(int i = 1; i < N-1; i++){
                max = Math.Max(max, K1[i-1]+K2[i+1]);
            }

            return max;
        }
    }
}