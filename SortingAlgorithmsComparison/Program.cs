using SortingAlgorithmsComparison;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] hundredIntegers = GenerateArrays.GenerateArray(100);
        int[] tenThousandIntegers = GenerateArrays.GenerateArray(10000);

        SortingAlgorithms.SelectionSort(hundredIntegers);
        SortingAlgorithms.SelectionSort(tenThousandIntegers);

        SortingAlgorithms.BubbleSort(hundredIntegers);
        SortingAlgorithms.BubbleSort(tenThousandIntegers);

        SortingAlgorithms.QuickSort(hundredIntegers);
        SortingAlgorithms.QuickSort(tenThousandIntegers);

        SortingAlgorithms.InsertionSort(hundredIntegers);
        SortingAlgorithms.InsertionSort(tenThousandIntegers);

        SortingAlgorithms.BucketSort(hundredIntegers);
        SortingAlgorithms.BucketSort(tenThousandIntegers);
    }

    private static void PrintArray(int[] integers)
    {
        for (int i = 0; i < integers.Length; i++)
        {
            Console.Write(integers[i] + " ");
        }

        Console.WriteLine();
    }
}