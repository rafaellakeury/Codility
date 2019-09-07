using System;
using System.Collections.Generic;
using System.Linq;

namespace CodilityLessons.PrefixSums
{
	class GeonomicRangeQuery
	{
		public int[] Solution(String S, int[] P, int[] Q)
		{
			List<int> result = new List<int>();
			var nucleotidesDictionary = new Dictionary<string, int>()
			{
				{"A", 1},
				{"C", 2},
				{"G", 3},
				{"T", 4}
			};
			var dnaSequence = S.ToCharArray(); //CAGCCTA

			for (int i = 0; i < P.Length; i++)
			{
				var subArray = dnaSequence.ToList().GetRange(P[i], Q[i]);
				var smaller = subArray.OrderBy(x => x).ToList().First();
				result.Add(smaller);
			}
			return result.ToArray();
		}
	}
}