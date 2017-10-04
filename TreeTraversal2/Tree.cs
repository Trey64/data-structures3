using System;
using System.Collections.Generic;
using System.Text;

namespace TreeTraversal2
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

        public void PostOrder()
        {
            if (Right != null)
            {
                Right.PostOrder();
            }
            if (Left != null)
            {
                Left.PostOrder();
            }
            Console.WriteLine(Data);
        }

        public void InOrder()
        {
            if (Left != null)
            {
                Left.InOrder();
            }
            Console.WriteLine(Data);
            if (Right != null)
            {
                Right.InOrder();
            }
        }

    }
}
