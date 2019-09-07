using System;

namespace CodilityLessons.CountingElements
{
	class FrogRiver
	{
		public static int Solution(int X, int[] A)
		{
			//[1, 3, 1, 4, 2, 3, 5, 4]
			//[true, false, true, false, false]
			//counter = 2

			int counter = 0;
			bool[] result = new bool[X];
			foreach (int element in A)
			{
				if (result[element - 1] == false)
				{
					result[element - 1] = true;
					counter++;
				}
				if (counter == X)
				{
					return Array.IndexOf(A, element);
				}
			}
			return -1;
		}
	}
}