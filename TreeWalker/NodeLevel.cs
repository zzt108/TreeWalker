using System.Collections.Generic;

namespace TreeWalker
{
    public class NodeLevel : List<Node>
    {
        public NodeLevel(List<Node> nodes)
        {
            AddRange(nodes);
        }
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