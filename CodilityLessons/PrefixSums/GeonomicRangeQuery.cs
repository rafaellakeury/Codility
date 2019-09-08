using System;
using System.Collections.Generic;

namespace CodilityLessons.PrefixSums
{
	class GeonomicRangeQuery
	{
		public int[] Solution(String S, int[] P, int[] Q)
		{
			//'GT', [0, 0, 1], [0, 1, 1]
			var nucleotidesDictionary = new Dictionary<string, int>()
			{
				{"A", 1},
				{"C", 2},
				{"G", 3},
				{"T", 4}
			};
			List<int> result = new List<int>();
			int[] aCounter = new int[S.Length];
			int[] cCounter = new int[S.Length];
			int[] gCounter = new int[S.Length];
			int[] tCounter = new int[S.Length];


			var dnaSequence = S.ToCharArray(); //GT

			int aCount = 0; int cCount = 0; int gCount = 0; int tCount = 0;
			for (int i = 0; i < dnaSequence.Length; i++)
			{
				if (dnaSequence[i].ToString().Equals("A"))
				{
					aCount++;
				}
				else if (dnaSequence[i].ToString().Equals("C"))
				{
					cCount++;
				}
				else if (dnaSequence[i].ToString().Equals("G"))
				{
					gCount++;
				}
				else
				{
					tCount++;
				}
				aCounter[i] = aCount;
				cCounter[i] = cCount;
				gCounter[i] = gCount;
				tCounter[i] = tCount;
			}

			for (int i = 0; i < P.Length; i++)
			{
				var valToAdd = 0;
				var from = P[i] > 0 ? P[i] - 1 : P[i];
				var to = Q[i];
				if (P[i] == Q[i])
				{
					var letra = dnaSequence[P[i]].ToString();
					valToAdd = nucleotidesDictionary[letra];
				}
				else if (aCounter[to] - aCounter[from] > 0 || (P[i] == 0 && aCounter[to] > 0))
				{
					valToAdd = 1;
				}
				else if (cCounter[to] - cCounter[from] > 0 || (P[i] == 0 && cCounter[to] > 0))
				{
					valToAdd = 2;
				}
				else if (gCounter[to] - gCounter[from] > 0 || (P[i] == 0 && gCounter[to] > 0))
				{
					valToAdd = 3;
				}
				else
				{
					valToAdd = 4;
				}

				result.Add(valToAdd);
			}
			return result.ToArray();
		}

	}
}