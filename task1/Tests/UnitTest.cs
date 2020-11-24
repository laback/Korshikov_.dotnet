using BakeryLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Bread bread = new Bread();
            Assert.AreEqual(Math.Round(bread.GetCost(),2), 126.05 + 59);
        }
    }
}
