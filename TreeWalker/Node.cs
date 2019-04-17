using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeWalker
{
    public class Node
    {
        private const int ChildCount = 2;

        private static bool Odd(int number)
        {
            return (number % 2) == 0;
        }

        private bool ValidChild(Node parent)
        {
            return (Odd(Data) != Odd(parent.Data));
        }

        public Node(int data)
        {
            Data = data;
            Children = new Node[ChildCount];
            Parents = new List<Node>();
        }
        public int Data { get; }
        public Node[] Children { get; }
        public List<Node> Parents { get; }

        public IEnumerable<Node> ValidChildren
        {
            get { return Children.Where(node => node.ValidChild(this)); }
        }

        public override string ToString()
        {
            if (Children[0] == null)
            {
                return Data.ToString();
            }
            return $"{Data}[{Children[0]}:{Children[1]}]";
        }
    }
}