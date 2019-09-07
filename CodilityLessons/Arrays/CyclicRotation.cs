namespace CodilityLessons.Arrays
{
	class CyclicRotation
	{
		public int[] Solution(int[] A, int K)
		{
			if (A.Length > 0)
			{
				while (K > 0)
				{
					var temp = A[A.Length - 1];
					for (int i = A.Length - 1; i > 0; i--)
					{

						A[i] = A[i - 1]; //a[1] = a[0]
					}
					A[0] = temp;

					K--;
				}
			}
			return A;
		}
	}
}