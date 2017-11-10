using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The {n}th number of the Fibonacci sequence is {FindNthofFib(n)}.");

            Console.Read();
        }


        static int FindNthofFib(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            //using recursion to add the previous 2 numbers in the sequence
            return FindNthofFib(n - 1) + FindNthofFib(n - 2);
        }
    }
}
