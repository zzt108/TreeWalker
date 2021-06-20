using System.Collections.Generic;
using System.Linq;

namespace TreeWalker.Route
{
    /// <summary>
    /// A sequence of nodes, making a route
    /// </summary>
    public class Route : List<Node.Node>
    {
        public Route(Node.Node start)
        {
            Add(start);
        }

        /// <summary>
        /// Cloning constructor
        /// </summary>
        /// <param name="clone">Route to clone</param>
        public Route(Route clone)
        {
            this.AddRange(clone);
        }

        /// <summary>
        /// Returns sum of node values in the route
        /// </summary>
        public int RouteSum
        {
            get { return this.Sum(node => node.Data); }
        }
        /// <summary>
        /// Shows if the route is valid
        /// According to the specification a route is valid if it's last node is in the last row of the triangle
        /// This condition is true if the last node has no children
        /// </summary>
        public bool IsValid => this.Last().HasNoChildren;

        /// <summary>
        ///  Add valid child node to the route. If there is more than one valid child then a cloned route vith the other child is also added to the routeList
        /// </summary>
        /// <param name="routeList">Route list containing all possible routes. May get new routes added in this method</param>
        public void Grow(RouteList routeList)
        {
            if (!IsValid)
            {
                var validChildren = this.Last().ValidChildren.ToList();
                if (validChildren.Count()>1)    // if the node has more than one valid child
                {
                    //clone the route led to here and add the "other" child node to the clone
                    var newRoute = new Route(this) {validChildren.Last()}; // adds last node
                    //add the new possible route to the processed routes list. The caller will process these additional routes too.
                    routeList.Add(newRoute);
                }

                if (validChildren.Any())
                {
                    Add(validChildren.First());
                    // recursively add new nodes to all routes in routelist
                    routeList.Grow();
                }
            }
        }

        public override string ToString()
        {
            return string.Join("->", this.Select(node => node.Data)) + $" Sum: {RouteSum}";
        }
    }
}