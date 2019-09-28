using CodilityLessons.Sorting;
using NUnit.Framework;


namespace CodilityLessonsTests.Sorting
{
	[TestFixture]
	class MaxProductOfThreeTests
	{
		[Test]
		public void TestBasicCase()
		{
			//Given
			var baseCaseArray = new int[] {-3, 1, 2, -2, 5, 6};
			var maxProductOfThree = new MaxProductOfThree();
			var expectedResult = 60;

			//When
			var actualResult = maxProductOfThree.Solution(baseCaseArray);

			//Then
			Assert.AreEqual(expectedResult, actualResult);
		}

		[Test]
		public void SimpleTest()
		{
			//Given
			var baseCaseArray = new int[] { -5, 5, -5, 4 }; 
			var maxProductOfThree = new MaxProductOfThree();
			var expectedResult = 125;

			//When
			var actualResult = maxProductOfThree.Solution(baseCaseArray);

			//Then
			Assert.AreEqual(expectedResult, actualResult);
		}

		[Test]
		public void AnotherSimpleTest()
		{
			//Given
			var baseCaseArray = new int[] { 4, 7, 3, 2, 1, -3, -5 }; 
			//7 4 3
			//5 3 -> 105
			var maxProductOfThree = new MaxProductOfThree();
			var expectedResult = 105;

			//When
			var actualResult = maxProductOfThree.Solution(baseCaseArray);

			//Then
			Assert.AreEqual(expectedResult, actualResult);
		}

		[Test]
		public void SecondSimpleTest()
		{
			//Given
			var baseCaseArray = new int[] { 2, 3, 100, -1000 };
			var maxProductOfThree = new MaxProductOfThree();
			var expectedResult = 600;

			//When
			var actualResult = maxProductOfThree.Solution(baseCaseArray);

			//Then
			Assert.AreEqual(expectedResult, actualResult);
		}

		//-2, -3, -5, -6, 0
		[Test]
		public void OutOfRangeTest()
		{
			//Given
			var baseCaseArray = new int[] { -2, -3, -5, -6, 0 };
			var maxProductOfThree = new MaxProductOfThree();
			var expectedResult = 0;

			//When
			var actualResult = maxProductOfThree.Solution(baseCaseArray);

			//Then
			Assert.AreEqual(expectedResult, actualResult);
		}
	}
}