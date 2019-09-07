using System;

namespace CodilityLessons.Iterations
{
	class BinaryGap
	{
		public int Solution(int n)
		{
			var highestGap = 0;
			var binaryRepresentation = Convert.ToString(n, 2);

			int gapCount = 0;
			foreach (var ch in binaryRepresentation)
			{
				var number = Convert.ToInt32(ch.ToString());
				if (number.Equals(0))
					gapCount++;
				else
				{
					if (gapCount > highestGap)
					{
						highestGap = gapCount;
					}
					gapCount = 0;

				}
			}
			return highestGap;
		}
	}
}