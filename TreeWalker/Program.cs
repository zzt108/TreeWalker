using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeWalker
{
    public class Node
    {
        public Node(int data)
        {
            Data = data;
            Children = new Node[2];
        }
        public int Data { get; }
        public Node[] Children { get; }
        public override string ToString()
        {
            return Data.ToString();
        }
    }

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

    public class NodeTriangle : List<NodeLevel>
    {
        public NodeTriangle(List<NodeLevel> levels)
        {
            Console.WriteLine($"ctor - lines {this.Count}");
            if (levels != null)
            {
                AddRange(levels);
            }
        }
    }

    public class Program
    {
        //public static Node Root = new Node(215);
        public static NodeTriangle Triangle = new NodeTriangle(null)
        {
            new NodeLevel(new []{215})  ,
            new NodeLevel(new []{192, 124})
        };

        public static void Main(string[] args)
        {
            foreach (var level in Triangle)
            {
                Console.WriteLine(level);
            }
        }
    }
}
