using System.Collections.Generic;
using System.Linq;

namespace CodilityLessons.Leader
{
    public class DominatorSecondRound
    {
        public int Solution(int[] A)
        {
            if(A.Count() == 0)
                return -1;

            Dictionary<int, int> valueAndQuantity = new Dictionary<int, int>();
            decimal botttomThreshold = A.Count()/2;

            foreach(int element in A)
            {
                if(valueAndQuantity.ContainsKey(element))
                {
                    valueAndQuantity[element]++;
                }
                else
                {
                    valueAndQuantity.Add(element, 1);
                }
            }

            var maxValue = valueAndQuantity.Max(v => v.Value);
            if(maxValue > botttomThreshold)
            {
                return A.ToList().IndexOf(valueAndQuantity.First(el => el.Value == maxValue).Key);
            }

            return -1;
        }
    }
}