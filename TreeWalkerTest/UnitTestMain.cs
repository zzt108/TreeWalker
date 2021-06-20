using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreeWalker;
using TreeWalker.Node;
using TreeWalker.Route;

namespace TreeWalkerTest
{
    [TestClass]
    public class UnitTestMain
    {
        public static NodeTriangle TestTriangle = new NodeTriangle(
            new List<NodeLevel>
            {
                new NodeLevel(new []{1})  ,
                new NodeLevel(new []{8, 9})  ,
                new NodeLevel(new []{1, 5, 9})  ,
                new NodeLevel(new []{4, 5, 2, 3})
            });

        /// <summary>
        /// Executes main method. Tests if any exception occurs
        /// </summary>
        [TestMethod]
        public void TestMain()
        {
            TreeWalker.Program.Main(null);
        }

        /// <summary>
        /// Writes test triangle to the console for check of correct linking of nodes
        /// </summary>
        [TestMethod]
        public void WriteTestData()
        {
            foreach (var level in TestTriangle)
            {
                Console.WriteLine(level);
            }
        }

        /// <summary>
        /// Get all possible routes from test data. Checks if recursion is not infinite and writes possible routes to the console
        /// </summary>
        [TestMethod]
        public void GetRoutes()
        {
            var routes = new RouteList(TestTriangle[0][0]);
            routes.Grow();
            foreach (var route in routes)
            {
                Console.WriteLine(route);
            }
        }
    }
}
