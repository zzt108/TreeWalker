using System.Collections.Generic;
using System.Linq;

namespace TreeWalker
{
    public class Route : List<Node>
    {
        public Route(Node start)
        {
            Add(start);
        }

        public Route(Route clone)
        {
            this.AddRange(clone);
        }

        public int RouteSum
        {
            get { return this.Sum(node => node.Data); }
        }

        public bool HasValidEnd => this.Last().HasNoChildren;

        public void Grow(RouteList routeList)
        {
            if (!HasValidEnd)
            {
                var validChildren = this.Last().ValidChildren.ToList();
                if (validChildren.Count()>1)
                {
                    var newRoute = new Route(this) {validChildren.Last()}; // adds last node
                    routeList.Add(newRoute);
                }
                Add(validChildren.First());
                routeList.Grow();
            }
        }

        public override string ToString()
        {
            return string.Join("->", this.Select(node => node.Data)) + $" Sum: {RouteSum}";
        }
    }
}