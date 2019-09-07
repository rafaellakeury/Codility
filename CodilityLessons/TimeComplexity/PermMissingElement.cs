using System.Linq;

namespace CodilityLessons.TimeComplexity
{
	class PermMissingElement
	{
		public int Solution(int[] A)
		{
			// 2 3 1 5 - 4 elementos: de 1 a 5 = 5 + 4 + 3 + 2 + 1 = 15
			// 2 + 3 + 1 + 5 = 11
			//
			long baseNumber = A.Length + 1;
			var totalSum = (baseNumber * (baseNumber + 1)) / 2;
			var missingElement = totalSum - A.Select(x => (long)x).Sum();
			return (int)missingElement;
		}
	}
}