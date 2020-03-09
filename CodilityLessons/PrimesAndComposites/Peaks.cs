using System.Collections.Generic;

namespace CodilityLessons.PrimesAndComposites
{
    public class Peaks
    {
        public int Solution(int[] A)
        {
            int N = A.Length;

            List<int> peaks = new List<int>();
            for(int i = 1; i < N-1; i++)
            {
                if(A[i] > A[i-1] && A[i] > A[i+1])
                    peaks.Add(i);
            }

            for(int size = 1; size <= N; size++)
            {
                if(N % size != 0)
                    continue;

                int find = 0;
                int groups = N/size;
                bool foundGroupsCount = true;

                foreach(int peakIndex in peaks)
                {
                    if(peakIndex/size > find)
                    {
                        foundGroupsCount = false;
                        break;
                    }
                    if(peakIndex/size == find)
                        find++;
                }
                if(find != groups)
                    foundGroupsCount = false;
                if(foundGroupsCount)
                    return groups;
            }
            return 0;
        }
    }
}