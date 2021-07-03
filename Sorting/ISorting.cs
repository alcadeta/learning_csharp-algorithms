namespace Sorting
{
    public interface ISorting<T>
    {
        long Swaps { get; }
        long Comparisons { get; }
        T[] Sort(T[] data);
        T[] MetricSort(T[] data);
    }
}