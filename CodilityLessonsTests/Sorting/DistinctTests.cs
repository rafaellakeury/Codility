using CodilityLessons.Sorting;
using NUnit.Framework;

namespace CodilityLessonsTests.Sorting
{
	[TestFixture]
	class DistinctTests
	{
		[Test]
		public void TestBasicCase()
		{
			//Given
			var baseCaseArray = new int[] { 2, 1, 1, 2, 3, 1 };
			var distinct = new Distinct();
			var expectedResult = 3;

			//When
			var actualResult = distinct.Solution(baseCaseArray);

			//Then
			Assert.AreEqual(expectedResult, actualResult);
		}
	}
}
