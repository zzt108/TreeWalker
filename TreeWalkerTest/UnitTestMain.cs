using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TreeWalkerTest
{
    [TestClass]
    public class UnitTestMain
    {
        [TestMethod]
        public void TestMain()
        {
            TreeWalker.Program.Main(null);
        }
    }
}
