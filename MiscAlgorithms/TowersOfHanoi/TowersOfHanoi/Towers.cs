using System;
using System.Collections.Generic;
using System.Text;

namespace TowersOfHanoi
{
    class Towers
    {
        public void MoveTower(int discs, string start, string aux, string end)
        {
            if (discs == 1)
            {
                Console.WriteLine(start + " -> " + end);
            }
            if (discs > 1)
            {
                MoveTower(discs - 1, start, end, aux);
                Console.WriteLine(start + " -> " + end);
                MoveTower(discs - 1, aux, start, end);
            }
        }
    }
}
