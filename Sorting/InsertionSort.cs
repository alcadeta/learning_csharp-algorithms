using System;

namespace Sorting
{
    public class InsertionSort<T> : SortingMetrics<T>
        where T : IComparable
    {
        public override T[] MetricSort(T[] data)
        {
            for (var i = 1; i < data.Length; i++)
                if (LessThan(data, i, i - 1))
                    for (var j = i; j > 0; j--)
                        if (LessThan(data, j, j - 1))
                            Swap(data, j, j - 1);
                        else
                            break;
            return data;
        }
    }
}