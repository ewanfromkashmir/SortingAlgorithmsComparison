using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace SortingAlgorithmsComparison
{
    [MemoryDiagnoser]
    internal class SortingAlgorithms
    {
        [Benchmark]
        public static int[] SelectionSort(int[] integers)
        {
            for (int i = 0; i < integers.Length; i++)
            {
                int smallestInteger = i;

                for (int j = i + 1; j < integers.Length; j++)
                {
                    if (integers[j] < integers[smallestInteger])
                    {
                        smallestInteger = j;
                    }
                }

                int temporaryInteger = integers[smallestInteger];
                integers[smallestInteger] = integers[i];
                integers[i] = temporaryInteger;
            }
            
            return integers;
        }

        [Benchmark]
        public static int[] BubbleSort(int[] integers) 
        {
            int temporaryInteger; ;
           
            for (int i = 0; i < integers.Length; i++) 
            { 
                for (int j = 0; j < integers.Length - 1; j++)
                {
                    if (integers[j] > integers[j+1])
                    {
                        temporaryInteger = integers[j];
                        integers[j] = integers[j + 1];
                        integers[j + 1] = temporaryInteger;
                    }
                }
            }

            return integers;
        }

        [Benchmark]
        public static int[] QuickSort(int[] integers)
        {
            Array.Sort(integers);
            return integers;
        }

        [Benchmark]
        public static int[] InsertionSort(int[] integers) 
        {
            for (int i = 0; i < integers.Length - 1; i++) 
            { 
                for (int j = i + 1; j > 0; j--)
                {
                    if (integers[j-1] > integers[j])
                    {
                        int temporaryInteger = integers[j - 1];
                        integers[j-1] = integers[j];
                        integers[j] = temporaryInteger;
                    }
                }
            }

            return integers;
        }

        [Benchmark]
        public static int[] BucketSort(int[] integers) 
        {
            int minimumValue = integers[0];
            int maximumValue = integers[0];

            for (int i = 1; i < integers.Length; i++)
            {
                if (integers[i] > maximumValue)
                {
                    maximumValue = integers[i];
                }

                if (integers[i] < minimumValue)
                {
                    minimumValue = integers[i];
                }
            }

            List<int>[] bucket = new List<int>[maximumValue - minimumValue + 1];
            
            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();
            }

            for (int i = 0; i < integers.Length; i++)
            {
                bucket[integers[i] - minimumValue].Add(integers[i]);
            }

            int k = 0;

            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i].Count > 0)
                {
                    for (int j = 0; j < bucket[i].Count; j++)
                    {
                        integers[k] = bucket[i][j];
                        k++;
                    }
                }
            }

            return integers;
        }
    }
}
