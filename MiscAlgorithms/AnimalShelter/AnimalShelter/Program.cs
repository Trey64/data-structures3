using System;
using System.Collections;

namespace AnimalShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue Animals = new Queue();
            Animals.Enqueue("cat1");
            Animals.Enqueue("cat2");
            Animals.Enqueue("dog2");
            Animals.Enqueue("cat3");
            Animals.Enqueue("dog2");
            Animals.Enqueue("dog3");

            Console.WriteLine("GETTING ANY PET");
            GetPet(Animals);
            Console.WriteLine("");


            Console.WriteLine("GETTING A SPECIFIC PET");
            Console.WriteLine("Would you like a cat or dog?");
            string choice = Console.ReadLine();
            GetSpecificPet(Animals, choice.ToLower());

            Console.Read();
        }

        //if user has no preference, dequeue and return first pet
        public static void GetPet(Queue Animals)
        {
            Console.WriteLine($"Here is your new pet: {Animals.Dequeue()}");
        }

        //if user wants specific type of pet, peek and check if it contains the same type
        public static void GetSpecificPet(Queue Animals, string type)
        {
            if (Animals.Peek().ToString().Contains(type))
            {
                Console.WriteLine($"Here is your new pet: {Animals.Dequeue()}");
            }
            else
            {
                Queue Rejects = new Queue();

                //dequeue  from Animals and enqueue into Rejects while types aren't the same
                while (!Animals.Peek().ToString().Contains(type))
                {
                    Rejects.Enqueue(Animals.Dequeue());
                }

                if (Animals == null)
                {
                    Console.WriteLine("All pets have been rescued!");
                }

                Console.WriteLine($"Here is your new pet: {Animals.Dequeue()}");
            }
        }
    }
}