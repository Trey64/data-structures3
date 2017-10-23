using System;

namespace AnimalGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree testTree = new Tree("Can it fly?");
            testTree.Root.Left = new Node("Is it NOT extinct?")
            {
                Left = new Node("eagle"),
                Right = new Node("pterydactyl")
            };

            testTree.Root.Right = new Node("Does it lay eggs?")
            {
                Left = new Node("snake"),
                Right = new Node("monkey")
            };

            testTree.Question(testTree.Root);

            Console.Read();
        }
    }
}
