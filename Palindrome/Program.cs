using System;

namespace Palindrome
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

            IsPalindrome();

            Console.Read();


        }

        public static void IsPalindrome()
        {
            Console.WriteLine("Enter a word to check if it's a palindrome!");
            Queue palinQ = new Queue();
            string oldWord = Console.ReadLine();
            string newWord = "";

            for (int i = oldWord.Length - 1; i >= 0; i--)
            {
                palinQ.Enqueue(oldWord[i]);
            }


            for (int i = 0; i < oldWord.Length; i++)
            {
                newWord += palinQ.Dequeue();
            }

            if (newWord == oldWord)
            {
                Console.WriteLine($"{oldWord} is a palindrome!");
            }
            else
            {
                Console.WriteLine($"{oldWord} is NOT a palindrome!");
            }
        }
    }
}
