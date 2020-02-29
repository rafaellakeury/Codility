using CodilityLessons.PrimesAndComposites;
using NUnit.Framework;

namespace CodilityLessonsTests.PrimesAndComposites
{
	[TestFixture]
    public class MinPerimeterRectangleTests
    {
        [Test]
		public void WhenSendind30ShouldReturn22()
		{
            var expectedValue = 22;
			var countFactors = new MinPerimeterRectangle();
			var actualValue = countFactors.Solution(30);
			Assert.AreEqual(expectedValue, actualValue);
        }

    }
}