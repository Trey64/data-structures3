﻿using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            const int max = 20;
            Random rnd = new Random();
            int[] unsortedArray = new int[max];

            for (int i = 0; i < unsortedArray.Length; i++)
            {
                unsortedArray[i] = rnd.Next(1, 100);
            }

            Console.WriteLine($"Unsorted array: {String.Join(" ", unsortedArray)}");

            //Sorts the array
            QuickSort(unsortedArray);

            Console.WriteLine($"Sorted array: {String.Join(" ", unsortedArray)}");
            Console.Read();
        }

        static void QuickSort(int[] array, int low, int high)
        {
            //If element is out of bounds, return nothing
            if (array.Length <= 1 || low < 0 || high < 0 || (high - low) < 1)
            {
                return;
            }

            if (low < high)
            {
                int pivot = Partition(array, low, high);
                //Recursive calls
                QuickSort(array, low, pivot - 1);
                QuickSort(array, pivot + 1, high);
            }
        }

        static void QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        //Reorders array around pivot
        static int Partition(int[] array, int low, int high)
        {
            //Pivot selection
            int pivot = array[high];
            int i = low - 1;

            for (int j = low; j <= high - 1; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            if (array[high] < array[i + 1])
            {
                Swap(array, i + 1, high);
            }
            return i + 1;
        }

        static void Swap(int[] array, int i, int j)
        {
            int temp = array[j];
            array[j] = array[i];
            array[i] = temp;
        }

    }
}