using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    class MxNMatrix
    {
        int[,] matrixArray = new int[2, 2]
        {
                { 2, 5 },
                { 8, 0 },
        };

        public int Rows { get; set; }
        public int Columns { get; set; }

        public MxNMatrix(int rows, int columns)
        {
            matrixArray = new int[rows, columns];
            Rows = rows;
            Columns = columns;
        }

        public void FindZero(int x, int y, int value)
        {
            if (value == 0)
            {
                for (int i = 0; i < Rows; i++)
                {
                    matrixArray[i, y] = 0;
                }

                for (int j = 0; j < Columns; j++)
                {
                    matrixArray[x, j] = 0;
                }
            }
            else
            {
                matrixArray[x, y] = value;
            }
        }
    }
}
