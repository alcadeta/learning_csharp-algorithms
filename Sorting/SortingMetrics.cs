using System;

namespace Sorting
{
    // TODO: Create ISorting and implement it. 
    public abstract class SortingMetrics<T> : ISorting<T>
    {
        public long Swaps { get; private set; }
        public long Comparisons { get; private set; }

        public T[] Sort(T[] data)
        {
            Reset();
            return MetricSort(data);
        }

        public abstract T[] MetricSort(T[] data);

        protected void Reset() 
        {
            Swaps = 0;
            Comparisons = 0;
        }
        
        protected void Swap(T[] data, int left, int right)
        {
            var temp = data[left];
            data[left] = data[right];
            data[right] = temp;
        }

        protected void Assign(T[] data, int index, T value)
        {
	    data[index] = value;
	    Swaps++;
        }
    }
}
