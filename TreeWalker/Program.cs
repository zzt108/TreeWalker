using System;
using System.Collections.Generic;
using System.Linq;
using TreeWalker.Node;
using TreeWalker.Route;

namespace TreeWalker
{
    public class Program
    {
        private static readonly NodeTriangle Triangle = new NodeTriangle(
            new List<NodeLevel>
        {
            new NodeLevel(new []{215})  ,
            new NodeLevel(new []{192, 124})  ,
            new NodeLevel(new []{117, 269, 442}) ,
            new NodeLevel(new []{218, 836, 347, 235}) ,
            new NodeLevel(new []{320,805, 522, 417, 345}) ,
            new NodeLevel(new []{229, 601, 728, 835, 133, 124}) ,
            new NodeLevel(new []{248, 202, 277, 433, 207, 263, 257}) ,
            new NodeLevel(new []{359, 464, 504, 528, 516, 716, 871, 182}) ,
            new NodeLevel(new []{461, 441, 426, 656, 863, 560, 380, 171, 923}) ,
            new NodeLevel(new []{381, 348, 573, 533, 448, 632, 387, 176, 975, 449}) ,
            new NodeLevel(new []{223, 711, 445, 645, 245, 543, 931, 532, 937, 541, 444}) ,
            new NodeLevel(new []{330, 131, 333, 928, 376, 733, 017, 778, 839, 168, 197, 197}) ,
            new NodeLevel(new []{131, 171, 522, 137, 217, 224, 291, 413, 528, 520, 227, 229, 928}) ,
            new NodeLevel(new []{223, 626, 034, 683, 839, 052, 627, 310, 713, 999, 629, 817, 410, 121}) ,
            new NodeLevel(new []{924, 622, 911, 233, 325, 139, 721, 218, 253, 223, 107, 233, 230, 124, 233}) ,
        });

        public static void Main(string[] args)
        {
            var routes = new RouteList(Triangle[0][0]);
            routes.Grow();
            var highestSumRoute = routes.OrderBy(route => route.RouteSum).LastOrDefault(route => route.IsValid);
            Console.WriteLine(highestSumRoute == null
                ? $"There is no valid route in the triangle"
                : $"Route with highest sum is {highestSumRoute}");
        }
    }
}
