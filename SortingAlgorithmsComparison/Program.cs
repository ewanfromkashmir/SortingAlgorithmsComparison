using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
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

        //Test comment to see if GitHub problem has been properly fixed

        SortingAlgorithms.QuickSort(hundredIntegers);
        SortingAlgorithms.QuickSort(tenThousandIntegers);

        SortingAlgorithms.InsertionSort(hundredIntegers);
        SortingAlgorithms.InsertionSort(tenThousandIntegers);

        SortingAlgorithms.BucketSort(hundredIntegers);
        SortingAlgorithms.BucketSort(tenThousandIntegers);

        var results0 = BenchmarkRunner.Run(SortingAlgorithms.SelectionSort(hundredIntegers));
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

[MemoryDiagnoser]
[SimpleJob(RuntimeMoniker.Net50)]
public class Demo
{
    [Benchmark]
    public string GetFullStringNormally()
    {
        string output = "";

        for (int i = 0; i < 1000; i++)
        {
            output += i;
        }

        return output;
        
    }  
}