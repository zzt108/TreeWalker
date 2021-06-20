using System.Collections.Generic;
using System.Linq;

namespace TreeWalker.Node
{
    /// <summary>
    /// A node in the triangle data (input provided to the app)
    /// </summary>
    public class Node
    {
        private const int ChildCount = 2;
        internal Node[] Children { get; }

        // Number contained in the node
        public int Data { get; }

        private static bool Odd(int number)
        {
            return (number % 2) == 0;
        }
       /// <summary>
       /// Shows if a child node is valid, according to the acceptance criteria. Currently a child is valid if its oddness is opposite to its parent's oddness.
       /// </summary>
       /// <param name="relative"></param>
       /// <returns></returns>
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
                return Data.ToString();
            else
                return $"{Data}[{Children[0]}:{Children[1]}]";
        }

    }
}