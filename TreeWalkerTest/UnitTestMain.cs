using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreeWalker;

namespace TreeWalkerTest
{
    [TestClass]
    public class UnitTestMain
    {
        public static NodeTriangle TesTriangle = new NodeTriangle(
            new List<NodeLevel>
            {
                new NodeLevel(new []{1})  ,
                new NodeLevel(new []{8, 9})  ,
                new NodeLevel(new []{1, 5, 9})  ,
                new NodeLevel(new []{4, 5, 2, 3})
            });

        [TestMethod]
        public void TestMain()
        {
            TreeWalker.Program.Main(null);
        }
        [TestMethod]
        public void WriteTestData()
        {
            foreach (var level in TesTriangle)
            {
                Console.WriteLine(level);
            }
        }
    }
}
