using CodilityLessons.Leader;
using NUnit.Framework;

namespace CodilityLessonsTests.Leader
{
	[TestFixture]
	class EquileaderTests
	{
		[Test]
		public void WhenSendindDefaultArrayShouldReturn2()
		{
			var expectedValue = 2;
			var equiLeader = new Equileader();
			var baseCaseArray = new int[] {4, 3, 4, 4, 4, 2};
			var actualValue = equiLeader.Solution(baseCaseArray);
			Assert.AreEqual(expectedValue, actualValue);
		}
	}
}