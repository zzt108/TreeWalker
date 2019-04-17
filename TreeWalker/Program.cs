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
            if (Children[0] == null)
            {
                return Data.ToString();
            }
            return $"{Data}[{Children[0]}:{Children[1]}]";
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
            if (levels != null)
            {
                AddRange(levels);
                HookUpData();
            }
        }

        private void HookUpData()
        {
            Node[] prevLevel = null;
            foreach (var level in this)
            {

                if (prevLevel != null)
                {
                    var thisLevel = level.ToArray();
                    for (var i = 0; i < prevLevel.Length; i++)
                    {
                        prevLevel[i].Children[0] = thisLevel[i];
                        prevLevel[i].Children[1] = thisLevel[i+1];
                    }
                }

                prevLevel = level.ToArray();
            }
        }
    }

    public class Program
    {
        public static NodeTriangle Triangle = new NodeTriangle(
            new List<NodeLevel>
        {
            new NodeLevel(new []{215})  ,
            new NodeLevel(new []{192, 124})  ,
            new NodeLevel(new []{117, 269, 442})
        });

        public static void Main(string[] args)
        {
            foreach (var level in Triangle)
            {
                Console.WriteLine(level);
            }
        }
    }
}
