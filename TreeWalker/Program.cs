using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeWalker
{
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
