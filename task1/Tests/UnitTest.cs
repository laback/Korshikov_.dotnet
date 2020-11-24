using BakeryLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestFileRead()
        {
            Products products = new Products();
            int expected = 17;
            Assert.AreEqual(expected, products.countOfProd);
        }
        [TestMethod]
        public void TestCalorificSort()
        {
            Products products = new Products();
            AnyProduct[] anyProducts = products.ArraySort(SortState.Calorific);
            double min = anyProducts[0].GetCalorific();
            double max = anyProducts[products.countOfProd - 1].GetCalorific();
            Assert.IsTrue(min <= max);
        }
        [TestMethod]
        public void TestCostSort()
        {
            Products products = new Products();
            AnyProduct[] anyProducts = products.ArraySort(SortState.Cost);
            double min = anyProducts[0].GetCost();
            double max = anyProducts[products.countOfProd - 1].GetCost();
            Assert.IsTrue(min <= max);
        }
        [TestMethod]
        public void TestTakeIdentical()
        {
            Products products = new Products();
            Bun bun = new Bun();
            double cost = bun.GetCost();
            double calofiric = bun.GetCalorific();
            AnyProduct[] anyProducts = products.TakeIdentical(cost, calofiric);
            int count = 0;
            for(int i = 0; i < anyProducts.Length; i++)
            {
                if (anyProducts[i] != null)
                    count++;
                else break;
            }
            int expected = 3;
            Assert.AreEqual(expected, count);
        }
        [TestMethod]
        public void TestTakeIfMore()
        {
            Products products = new Products();
            AnyProduct[] anyProducts = products.TakeIfMore(new Flour(100));
            int count = 0;
            for (int i = 0; i < anyProducts.Length; i++)
            {
                if (anyProducts[i] != null)
                    count++;
                else break;
            }
            int expected = 9;
            Assert.AreEqual(expected, count);
        }
        [TestMethod]
        public void TestTakeByCount()
        {
            Products products = new Products();
            AnyProduct[] anyProducts = products.TakeByCount(4);
            int count = 0;
            for (int i = 0; i < anyProducts.Length; i++)
            {
                if (anyProducts[i] != null)
                    count++;
                else break;
            }
            int expected = 9;
            Assert.AreEqual(expected, count);
        }
    }
}
