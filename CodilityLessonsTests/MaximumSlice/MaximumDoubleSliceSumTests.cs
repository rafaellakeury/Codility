using CodilityLessons.MaximumSlice;
using NUnit.Framework;

namespace CodilityLessonsTests.MaximumSlice
{
	[TestFixture]    
    public class MaximumDoubleSliceSumTests
    {
        [Test]
		public void WhenSendindDefaultArrayShouldReturn5()
		{
            var expectedValue = 17;
			var maxProfit = new MaxDoubleSliceSum();
			var baseCaseArray = new int[] {3, 2, 6, -1, 4, 5, -1, 2};
			var actualValue = maxProfit.Solution(baseCaseArray);
			Assert.AreEqual(expectedValue, actualValue);
        }
    }
}