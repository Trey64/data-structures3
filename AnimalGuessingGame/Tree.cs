using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalGuessingGame
{
    class Tree
    {
        public Node Root { get; set; }

        public Tree(string data)
        {
            Root = new Node(data);
        }


        public void Question(Node curr)
        {
            if (curr.Left == null && curr.Right == null)
            {
                UserGuess(curr);
            }
            else
            {
                Console.WriteLine($"{curr.Data}");
                string answer = Console.ReadLine().ToLower();

                if (answer == "y" || answer == "yes")
                {
                    Question(curr.Left);
                }
                else
                {
                    Question(curr.Right);
                }
            }
        }

        public void UserGuess(Node node)
        {
            Console.WriteLine($"Were you thinking of a {node.Data}?");

            string answer = Console.ReadLine().ToLower();

            if (answer == "y" || answer == "yes")
            {
                Console.WriteLine("We da best!");
                PlayAgain();
            }
            else
            {
                Console.WriteLine("What were you thinking of?");
                string newAnimal = Console.ReadLine().ToLower();

                Console.WriteLine("What should I have asked?");
                string newQuestion = Console.ReadLine();

                node.Left = new Node(node.Data);
                node.Right = new Node(newAnimal);
                node.Data = newQuestion;

                PlayAgain();
            }
        }

        public void PlayAgain()
        {
            Console.WriteLine("Wanna play again?");

            string answer = Console.ReadLine().ToLower();

            if (answer == "y" || answer == "yes")
            {
                Question(Root);
                return;
            }
            else
            {
                Console.WriteLine("Thanks for playing!");
                return;
            }
        }
    }
}
