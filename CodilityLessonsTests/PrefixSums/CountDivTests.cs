using CodilityLessons.PrefixSums;
using NUnit.Framework;

namespace CodilityLessonsTests.PrefixSums
{
	[TestFixture]
	class CountDivTests
	{
		[Test]
		public void WhenSendind6And11And2ShouldReturn3()
		{
			var expectedValue = 3;
			var countDiv = new CountDiv();
			var actualValue = countDiv.Solution(6, 11, 2);
			Assert.AreEqual(expectedValue, actualValue);
		}

		[Test]
		public void WhenSendind11And345And17ShouldReturn20()
		{
			var expectedValue = 20;
			var countDiv = new CountDiv();
			var actualValue = countDiv.Solution(11, 345, 17);
			Assert.AreEqual(expectedValue, actualValue);
		}

		[Test]
		public void WhenSendind0And0And11ShouldReturn1()
		{
			var expectedValue = 1;
			var countDiv = new CountDiv();
			var actualValue = countDiv.Solution(0, 0, 11);
			Assert.AreEqual(expectedValue, actualValue);
		}

		[Test]
		public void WhenSendind10And10And7ShouldReturn0()
		{
			var expectedValue = 0;
			var countDiv = new CountDiv();
			var actualValue = countDiv.Solution(10, 10, 7);
			Assert.AreEqual(expectedValue, actualValue);
		}
	}
}