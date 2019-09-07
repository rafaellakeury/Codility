using System;

namespace CodilityLessons.TimeComplexity
{
	class FrogJump
	{
		public static int Solution(int X, int Y, int D)
		{
			//Y-X = 75 / D
			double count = (double)(Y - X) / (double)D;
			return (int)Math.Ceiling(count);
		}
	}
}