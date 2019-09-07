using System;

namespace CodilityLessons.CountingElements
{
	class MaxCounters
	{
		public static int[] Solution(int N, int[] A)
		{
			int[] counter = new int[N];
			int baseMinimum = 0;
			int possibleMinimum = 0;
			int index = 0;

			for (int i = 0; i < A.Length; i++)
			{
				index = A[i] - 1;

				if (index == N)
				{
					baseMinimum = possibleMinimum;
				}
				else
				{
					counter[index] = Math.Max(counter[index], baseMinimum);
					counter[index] += 1;

					if (possibleMinimum < counter[index])
					{
						possibleMinimum = counter[index];
					}
				}
			}

			for (int i = 0; i < counter.Length; i++)
			{
				counter[i] = Math.Max(counter[i], baseMinimum);
			}

			return counter;
		}

	}
}