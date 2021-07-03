using System.Linq;
using NUnit.Framework;

namespace Sorting.Tests
{
    public class BubbleSortTests
    {
        [Test]
        public void GivenAnUnorderedArrayOfNumbers_WhenBubbleSortMetricSortIsCalled_ThenReturnsOrderedNumbers()
        {
            var bubbleSort = new BubbleSort<int>();
            var unsortedNumbers = _Integers.GetUnsortedArray();
            var expectedResult = _Integers.GetSortedArray();

            var actualResult = bubbleSort.MetricSort(unsortedNumbers);

            Assert.IsTrue(actualResult.SequenceEqual(expectedResult));

            System.Console.WriteLine(
                $"Comparisons: {bubbleSort.Comparisons}\n" +
                $"Swaps: {bubbleSort.Comparisons}");
        }
    }
}