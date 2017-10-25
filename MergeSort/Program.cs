using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[] { 12, 76, 8, 99, 32, 64, 20, 50, 19 };

            Console.WriteLine($"Unsorted array: {PrintArray(testArray)}. \n");

            MergeSorting(testArray);

            Console.WriteLine($"Sorted array: {PrintArray(testArray)}.");

            Console.Read();
        }

        // Merge elements of an array by comparing values of each element to their corresponding element
        private static void Merge(int[] testArray, int low, int mid, int high)
        {
            int left = low;
            int right = mid + 1;
            int[] temp = new int[(high - low) + 1];
            int tempIndex = 0;

            while ((left <= mid) && (right <= high))
            {
                if (testArray[left] < testArray[right])
                {
                    temp[tempIndex] = testArray[left];
                    left += 1;
                }
                else
                {
                    temp[tempIndex] = testArray[right];
                    right += 1;
                }
                tempIndex += 1;
            }

            while (left <= mid)
            {
                temp[tempIndex] = testArray[left];
                left += 1;
                tempIndex += 1;
            }

            while (right <= high)
            {
                temp[tempIndex] = testArray[right];
                right += 1;
                tempIndex += 1;
            }

            for (int i = 0; i < temp.Length; i++)
            {
                testArray[low + i] = temp[i];
            }
        }

        // Recursively divides the array into halves, then compare and merge each section/pairs to rebuild array
        public static void MergeSorting(int[] testArray, int low, int high)
        {
            if (low < high)
            {
                int mid = (low / 2) + (high / 2);
                MergeSorting(testArray, low, mid);

                MergeSorting(testArray, mid + 1, high);

                Merge(testArray, low, mid, high);
            }
        }
        // This method lets us pass in just the array without any other arguments
        public static void MergeSorting(int[] testArray)
        {
            MergeSorting(testArray, 0, testArray.Length - 1);
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
