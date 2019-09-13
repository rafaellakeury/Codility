using NUnit.Framework;

namespace CodilityLessons.PrefixSums
{
	[TestFixture]
	class MinimumAverageTwoSliceTests
	{
		[Test]
		public void TestBasicCase()
		{
			//Given
			var baseCaseArray = new int[] {4, 2, 2, 5,1, 5, 8};
			var expectedResult = 1;
			var minimumAverageTwoSlice = new MinimumAverageTwoSlice();

			//When
			var actualResult = minimumAverageTwoSlice.Solution(baseCaseArray);

			//Then
			Assert.AreEqual(expectedResult, actualResult);
		}

		[Test]
		public void BestSliceHasLenghtOf3Case()
		{
			//Given
			var baseCaseArray = new int[] { -3, -5, -8, -4, -10 };
			var expectedResult = 2;
			var minimumAverageTwoSlice = new MinimumAverageTwoSlice();
			
			//When
			var actualResult = minimumAverageTwoSlice.Solution(baseCaseArray);

			//Then
			Assert.AreEqual(expectedResult, actualResult);
		}
	}
}
