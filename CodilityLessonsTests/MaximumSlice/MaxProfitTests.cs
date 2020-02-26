using CodilityLessons.MaximumSlice;
using NUnit.Framework;

namespace CodilityLessonsTests.MaximumSlice
{
	[TestFixture]
    public class MaxProfitTest
    {
        [Test]
		public void WhenSendindDefaultArrayShouldReturn356()
		{
            var expectedValue = 356;
			var maxProfit = new MaxProfit();
			var baseCaseArray = new int[] {23171, 21011, 21123, 21366, 21013, 21367};
			var actualValue = maxProfit.Solution(baseCaseArray);
			Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
		public void WhenSendindTwoIncreasingSubsequencesShouldReturnRightValue()
		{
            var expectedValue = 9;
			var maxProfit = new MaxProfit();
			var baseCaseArray = new int[] {0, 1, 6, 7, 8, 9};
			var actualValue = maxProfit.Solution(baseCaseArray);
			Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
		public void WhenAfterMaxAndBeforeMinMaxProfitShouldReturnRightValue()
		{
            var expectedValue = 7;
			var maxProfit = new MaxProfit();
			var baseCaseArray = new int[] {30, 1, 6, 7, 8, 0};
			var actualValue = maxProfit.Solution(baseCaseArray);
			Assert.AreEqual(expectedValue, actualValue);
        }
    }
}