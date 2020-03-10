using CodilityLessons.Leader;
using NUnit.Framework;

namespace CodilityLessonsTests.Leader
{
	[TestFixture]
	class DominatorTests
	{
		[Test]
		public void WhenSendindDefaultArrayShouldReturn0()
		{
			var expectedValue = 0;
			var equiLeader = new DominatorSecondRound();
			var baseCaseArray = new int[] {3, 4, 3, 2, 3, -1, 3, 3};
			var actualValue = equiLeader.Solution(baseCaseArray);
			Assert.AreEqual(expectedValue, actualValue);
		}
	}
}