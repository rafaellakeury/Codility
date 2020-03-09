using CodilityLessons.PrimesAndComposites;
using NUnit.Framework;

namespace CodilityLessonsTests.PrimesAndComposites
{
	[TestFixture]
    
    public class FlagsTests
    {
        [Test]
		public void ForBaseCaseShouldReturn3()
		{
            var expectedValue = 3;
			var baseCaseArray = new int[] { 1, 5, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 };
			var flags = new Flags();
			var actualValue = flags.Solution(baseCaseArray);
			Assert.AreEqual(expectedValue, actualValue);
        }
    }
}