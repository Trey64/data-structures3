using System;
using System.Collections.Generic;
using System.Text;

namespace InsertionSort
{
    class InsertionSorting
    {

        public int[] Insertion(int[] testArray)
        {
            for (var i = 1; i < testArray.Length; i++)
            {
                int j = i;

                while (j > 0)
                {
                    if (testArray[j - 1] > testArray[j])
                    {
                        int temp = testArray[j - 1];
                        testArray[j - 1] = testArray[j];
                        testArray[j] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return testArray;
        }
    }
}
