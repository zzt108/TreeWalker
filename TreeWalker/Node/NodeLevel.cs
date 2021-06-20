using System.Collections.Generic;

namespace TreeWalker.Node
{
    /// <summary>
    /// A row in the triangle data
    /// </summary>
    public class NodeLevel : List<Node>
    {
        public NodeLevel(IEnumerable<int> data)
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