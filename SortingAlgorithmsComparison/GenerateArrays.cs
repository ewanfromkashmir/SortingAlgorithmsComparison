using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmsComparison
{
    internal class GenerateArrays
    {
        public static int maximumValue = 10000;

        public static int[] GenerateArray(int length)
        {
            Random random = new Random();
            int[] integers = new int[length];
            
            for (int i = 0; i < length; i++) 
            {
                integers[i] = random.Next(maximumValue);
            }

            return integers;
        }
    }
}
