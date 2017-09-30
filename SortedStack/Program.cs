using System;

namespace SortedStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack:");
            Stack testS = new Stack();
            testS.Push("o");
            testS.Push("x");
            testS.Push("d");
            testS.Push("a");
            testS.Push("z");
            testS.Pop();

            Console.WriteLine("");
            Console.WriteLine("Sorted:");
            testS.SortPush("k");


            Console.Read();
        }
    }
}
