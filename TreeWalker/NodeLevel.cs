using System.Collections.Generic;

namespace TreeWalker
{
    /// <summary>
    /// A row in the triangle data
    /// </summary>
    public class NodeLevel : List<Node>
    {
        public NodeLevel(int[] data)
        {
            foreach (var i in data)
            {
                Add(new Node(i));
            }
        }

        public override string ToString()
        {
            return string.Join(" ", this);
        }
    }
}