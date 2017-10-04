using System;
using System.Collections.Generic;
using System.Text;

namespace TreeTraversal
{
    public class Tree
    {
        public int Data { get; set; }
        public Tree Left { get; set; }
        public Tree Right { get; set; }

        public Tree(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }

        public void Traverse()
        {
            Console.WriteLine(Data);
            if (Left != null)
            {
                Left.Traverse();
            }
            if (Right != null)
            {
                Right.Traverse();
            }
        }


    }
}
