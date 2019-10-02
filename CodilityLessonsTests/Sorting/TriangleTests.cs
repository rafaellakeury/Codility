using CodilityLessons.Sorting;
using NUnit.Framework;

namespace CodilityLessonsTests.Sorting
{
	[TestFixture]

	class TriangleTests
	{
		[Test]
		public void TestBasicCaseReturns1()
		{
			//Given
			var baseCaseArray = new int[] {10, 2, 5, 1, 8, 20};
			var triangle = new Triangle();
			var expectedResult = 1;

			//When
			var actualResult = triangle.Solution(baseCaseArray);

			//Then
			Assert.AreEqual(expectedResult, actualResult);
		}

		[Test]
		public void TestBasicCaseReturns0()
		{
			//Given
			var baseCaseArray = new int[] { 10, 50, 5, 1 };
			var triangle = new Triangle();
			var expectedResult = 0;

			//When
			var actualResult = triangle.Solution(baseCaseArray);

			//Then
			Assert.AreEqual(expectedResult, actualResult);
		}
	}
}
