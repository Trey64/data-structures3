using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTrees
{
    public class Tree
    {
        public Node Root;

        public void CreateTree(string data)
        {
            Root = new Node(data);
            Root.Left = new Node("One");
            Root.Right = new Node(" Two");
            Root.Left.Left = new Node("Three");
            Root.Left.Right = new Node(" Four");
            Root.Right.Left = new Node(" Five");
            Root.Right.Right = new Node(" Six");
        }

        public void PrintTree()
        {
            Console.WriteLine(Root.Data);
            Console.WriteLine(Root.Left.Data + Root.Right.Data);
            Console.WriteLine(Root.Left.Left.Data + Root.Left.Right.Data + Root.Right.Left.Data + Root.Right.Right.Data);
        }
    }
}
