using System.Linq;

namespace CodilityLessons.Arrays
{
	class OddOccurrencesInArray
	{
		public int solution(int[] A)
		{
			//int[] A = { 9, 3, 9, 3, 9, 7, 9 };
			//a
			return A.Aggregate((x, y) => x ^ y);
		}
	}
}
