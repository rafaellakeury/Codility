using System.Collections.Generic;

namespace CodilityLessons.CountingElements
{
	class MissingInteger
	{
		public int Solution(int[] A)
		{
			int result = 1;
			Dictionary<int, bool> found = new Dictionary<int, bool>();

			for (int i = 0; i < A.Length; i++)
			{
				if (A[i] > 0 && !found.ContainsKey(A[i]))
				{
					found.Add(A[i], true);
				}
			}

			while (found.ContainsKey(result))
			{
				result++;
			}

			return result;
		}

	}
}
