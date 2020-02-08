using System.Collections.Generic;

namespace CodilityLessons.Leader
{
    public class Dominator
    {
        public int solution(int[] A)
        {
            int lenght = A.Length;
            int leaderOccourrences = (lenght/2); //has to be more than this number

            int higherOcurrencyCount = 0;
            int leaderCandidateIndex = 0;
            Dictionary<int, int> numbersList = new Dictionary<int, int>();

            for(int i=0; i<lenght; i++)
            {
                if(numbersList.ContainsKey(A[i]))
                {
                    numbersList[A[i]]++;
                    if(numbersList[A[i]] > higherOcurrencyCount)
                    {
                        higherOcurrencyCount = numbersList[A[i]];
                        leaderCandidateIndex = i;
                    }
                }
                else
                {
                    numbersList.Add(A[i], 1);
                    if(higherOcurrencyCount < 1 )
                    {
                        higherOcurrencyCount++;
                        leaderCandidateIndex = i;
                    } 
                }
            }

            if(higherOcurrencyCount > leaderOccourrences) return leaderCandidateIndex;
            return -1;

        }
    }
}