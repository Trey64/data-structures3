using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            MxNMatrix theMatrix = new MxNMatrix(2, 2);

            theMatrix.FindZero(1, 1, 0);

            Console.WriteLine(theMatrix);
            Console.Read();
        }
    }
}