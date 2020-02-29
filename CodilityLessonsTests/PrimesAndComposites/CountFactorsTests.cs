using CodilityLessons.PrimesAndComposites;
using NUnit.Framework;

namespace CodilityLessonsTests.PrimesAndComposites
{
	[TestFixture]
    public class CountFactorsTests
    {
        [Test]
		public void WhenSendind24ShouldReturn8()
		{
            var expectedValue = 8;
			var countFactors = new CountFactors();
			var actualValue = countFactors.Solution(24);
			Assert.AreEqual(expectedValue, actualValue);
        }

    }
}