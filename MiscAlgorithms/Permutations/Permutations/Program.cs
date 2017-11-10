using System;
using System.Collections.Generic;
using System.Linq;

namespace Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abcdefg";
            char[] arr = str.ToCharArray();
            int n = arr.Length;

            Permute(arr, 0, n - 1);

            Console.Read();
        }

        //pass a and b as references
        public static void Swap(ref char a, ref char b)
        {
            char temp = a;
            a = b;
            b = temp;
        }
        
        //takes parameters of char, starting index, ending index
        public static void Permute(char[] letters, int l, int r)
        {
            //if set has only 1 element, return it
            if (l == r)
            {
                Console.WriteLine(letters);
                return;
            }
            //for each element in set, return element concatenated with permutation of rest of set
            for (int i = l; i <= r; i++)
            {
                Swap(ref letters[l], ref letters[i]);
                //recursion
                Permute(letters, l + 1, r);

                //backtracking
                Swap(ref letters[l], ref letters[i]);
            }
        }
    }
}
