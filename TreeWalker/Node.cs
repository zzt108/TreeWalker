using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeWalker
{
    public class Node
    {
        private const int ChildCount = 2;
        internal Node[] Children { get; }

        public int Data { get; }

        private static bool Odd(int number)
        {
            return (number % 2) == 0;
        }

        private bool ValidRelative(Node relative)
        {
            return (Odd(Data) != Odd(relative.Data));
        }

        public Node(int data)
        {
            Data = data;
            Children = new Node[ChildCount];
        }

        public IEnumerable<Node> ValidChildren
        {
            get { return Children.Where(child => child.ValidRelative(this)); }
        }

        public bool HasNoChildren
        {
            get { return Children.All(node => node == null); }
        }
        
        public override string ToString()
        {
            if (HasNoChildren)
            {
                return Data.ToString();
            }
            return $"{Data}[{Children[0]}:{Children[1]}]";
        }

    }
}