using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[] { 12, 76, 8, 99, 32, 64, 20, 50, 19 };

            Console.WriteLine($"Unsorted array: {PrintArray(testArray)}. \n");

            Console.WriteLine($"Sorted array: {PrintArray(InsertionSort(testArray))}.");

            Console.Read();
        }

        static int[] InsertionSort(int[] sortedArray)
        {
            // For each item in the array, except for the item in index 0. It's assumed to be properly sorted.
            for (int i = 1; i < sortedArray.Length; i++)
            {
                int j = i;

                // While current value being sorted is NOT in index 0 of the array
                while (j > 0)
                {
                    // If the value at index j is less than the value at index j - 1, replace j - 1 with j, then decrement j. Else, break out of the while loop.
                    if (sortedArray[j - 1] > sortedArray[j])
                    {
                        int temp = sortedArray[j - 1];
                        sortedArray[j - 1] = sortedArray[j];
                        sortedArray[j] = temp;
                        j--;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            // Return the sorted array
            return sortedArray;
        }

        static string PrintArray(int[] array)
        {
            string phrase = "";
            foreach (var item in array)
            {
                phrase += " " + item;
            }
            return phrase;
        }
    }
}