namespace CodilityLessons.CountingElements
{
	class PermCheck
	{
		//[4, 1, 3, 2]
		public static int Solution(int[] A)
		{
			int length = A.Length;
			bool[] result = new bool[length];
			foreach (int element in A)
			{
				if (element > length)
				{
					return 0;
				}
				else if (result[element - 1] == true)
				{
					return 0;
				}
				else
				{
					result[element - 1] = true;
				}

			}
			return 1;
		}
	}
}
