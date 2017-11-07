using System;

namespace TowersOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Towers tower = new Towers();

            //# of discs, start pole, aux pole, end pole
            tower.MoveTower(4, "start", "aux", "end");

            Console.Read();
        }
    }
}
