using System.Collections.Generic;

namespace TreeWalker
{
    /// <summary>
    /// A list of routes
    /// </summary>
    public class RouteList : List<Route>
    {
        public RouteList(Node start)
        {
            Add(new Route(start));
        }
        /// <summary>
        /// Walk all routes recursively. During the walk this list may get additional routes to walk, when a node have more than one valid child node 
        /// </summary>
        public void Grow()
        {
            var processed = 0;
            while (processed < Count)
            {
                this[processed].Grow(this);
                processed++;
            }
        }
    }
}