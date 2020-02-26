using CodilityLessons.MaximumSlice;
using NUnit.Framework;

namespace CodilityLessonsTests.MaximumSlice
{
	[TestFixture]
    public class MaxSliceSumTests
    {
        [Test]
		public void WhenSendindDefaultArrayShouldReturn5()
		{
            var expectedValue = 5;
			var maxProfit = new MaxSliceSum();
			var baseCaseArray = new int[] {3, 2, -6, 4, 0};
			var actualValue = maxProfit.Solution(baseCaseArray);
			Assert.AreEqual(expectedValue, actualValue);
        }
    }
}