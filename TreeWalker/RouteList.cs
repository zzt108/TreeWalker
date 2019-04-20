using System.Collections.Generic;

namespace TreeWalker
{
    public class RouteList : List<Route>
    {
        public RouteList(Node start)
        {
            Add(new Route(start));
        }

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