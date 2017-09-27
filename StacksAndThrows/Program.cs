using System;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue:");
            Queue testQ = new Queue();
            testQ.Enqueue("1");
            testQ.Enqueue("2");
            testQ.Enqueue("3");
            testQ.Enqueue("4");
            testQ.Dequeue();

            Console.WriteLine("");

            Console.WriteLine("Stack:");
            Stack testS = new Stack();
            testS.Push("1");
            testS.Push("2");
            testS.Push("3");
            testS.Push("4");
            testS.Pop();

            Console.Read();
        }
    }
}