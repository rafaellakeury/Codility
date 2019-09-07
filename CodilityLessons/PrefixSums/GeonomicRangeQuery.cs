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
			var dnaSequence = S.ToCharArray();
			var dnaSequenceValues = dnaSequence.Select(x => nucleotidesDictionary.First(y => y.Key.Equals(x.ToString())).Value)
				.ToArray();

			for (int i = 0; i < P.Length; i++)
			{
				var pPosition = P[i];
				var qPosition = Q[i];
				var smaller = dnaSequenceValues[pPosition];
				for (int j = pPosition; j <= qPosition; j++)
				{
					if (smaller > dnaSequenceValues[j])
					{
						smaller = dnaSequenceValues[j];
					}
				}
				result.Add(smaller);
			}

			return result.ToArray();
		}

	}
}