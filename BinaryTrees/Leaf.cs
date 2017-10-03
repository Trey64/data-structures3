using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTrees
{
    public class Leaf
    {
        public string Data { get; set; }
        public Leaf Left { get; set; }
        public Leaf Right { get; set; }

        public Leaf(string data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
}
