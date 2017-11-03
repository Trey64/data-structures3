using System;

namespace RotateMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 4;

            int[,] matrix = new int[4,4]
            {
                { 2, 4, 6, 8 },
                { 5, 10, 15, 20 },
                { 42, 66, 18, 55 },
                { 32, 76, 100, 89 }
            };

            Console.WriteLine("Original Matrix");
            PrintMatrix(N, matrix);

            Console.WriteLine("");
            Rotate(N, matrix);

            Console.WriteLine("Rotated Matrix");
            PrintMatrix(N, matrix);

            Console.Read();
        }

        static void Rotate(int N, int[,] matrix)
        {
            // account for each square
            for (int i = 0; i < N / 2; i++)
            {
                //split square into groups of smaller squares
                for (int j = i; j < N - i - 1; j++)
                {
                    //store matrix indices in temporary variable
                    int temp = matrix[i,j];

                    //shift corners of matrix once counter-clockwise
                    matrix[i,j] = matrix[j, N - 1 - i];

                    //move all 2nd from left values counter-clockwise
                    matrix[j, N - 1- i] = matrix[N - 1 - i, N - 1 - j];

                    //move all 3rd from left values counter-clockwise
                    matrix[N - 1 - i, N - 1 - j] = matrix[N - 1 - j, i];

                    //rotate middle values counter-clockwise
                    matrix[N - 1 - j, i] = temp;

                }
            }
        }

        static void PrintMatrix(int N, int[,] matrix)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(" " + matrix[i,j]);
                }
                Console.WriteLine(" ");
            }
        }
    }
}
