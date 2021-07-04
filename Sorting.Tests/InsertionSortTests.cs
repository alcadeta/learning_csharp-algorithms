using System.Linq;
using NUnit.Framework;

namespace Sorting.Tests
{
    public class InsertionSortTests
    {
        [Test]
        public void GivenAnUnorderedArrayOfNumbers_WhenBubbleSortMetricSortIsCalled_ThenReturnsOrderedNumbers()
        {
            var insertionSort = new InsertionSort<int>();
            var unsortedNumbers = new[] {0, 7, 2, 4, 1, 5, -4};
            var expectedResult = new[] {-4, 0, 1, 2, 4, 5, 7};

            var actualResult = insertionSort.MetricSort(unsortedNumbers);

            Assert.IsTrue(actualResult.SequenceEqual(expectedResult));

            System.Console.WriteLine(
                $"Comparisons: {insertionSort.Comparisons}\n" +
                $"Swaps: {insertionSort.Comparisons}");
        }
    }
}