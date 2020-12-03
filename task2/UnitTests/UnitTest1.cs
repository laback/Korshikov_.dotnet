using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductLib;
using System;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FileWorkTest()
        {
            Potatoes potatoes = new Potatoes("Картошка1", 10, 2, 50);
            Potatoes potatoes1 = new Potatoes("Картошка2", 12, 3, 20);
            List<Product> products = new List<Product>();
            products.Add(potatoes1);
            products.Add(potatoes);
            Products products1 = new Products();
            string path = @"D:\Учёба\EPAM\task2\ProductLib\bin\Debug\Products.json";
            products1.FileWrite(products, path);
            products = products1.FileRead(path);
            int expected = products.Count;
            Assert.AreEqual(expected, 2);
        }
        [TestMethod]
        public void TestGetCostAndSumCost()
        {
            Potatoes potatoes = new Potatoes("Картошка1", 10, 2, 50);
            Potatoes potatoes1 = new Potatoes("Картошка2", 12, 3, 20);
            List<Product> products = new List<Product>();
            products.Add(potatoes1);
            products.Add(potatoes);
            decimal expectedsum = potatoes1.GetCost();
            decimal expectedsums = potatoes1.GetAllCost(products);
            decimal expected = expectedsum + expectedsums;
            Assert.AreEqual(expected, Convert.ToDecimal(34.92));
        }
        [TestMethod]
        public void TestSum()
        {
            Food potatoes = new Potatoes("Картошка1", 10, 2, 50);
            Food potatoes1 = new Potatoes("Картошка1", 12, 3, 20);
            Food test = potatoes1 + potatoes;
            Assert.AreEqual(Math.Round(test.GetCost(),2), Convert.ToDecimal(11.06));
        }
        [TestMethod]
        public void TestDifference()
        {
            Food potatoes = new Potatoes("Картошка1", 10, 2, 50);
            potatoes -= 1;
            Assert.AreEqual(49, potatoes.Count);
        }
        [TestMethod]
        public void TestCast()
        {
            Food potatoes = new Potatoes("Картошка1", 10, 2, 50);
            Household household = potatoes;
            Assert.AreEqual(household.NameOfType, TypeName.Бытовая);
        }
        [TestMethod]
        public void TestCastToInt()
        {
            Food potatoes = new Potatoes("Картошка1", 10, 2, 50);
            int expected = potatoes;
            Assert.AreEqual(expected, 1000);
        }
        [TestMethod]
        public void TestCastToDouble()
        {
            Food potatoes = new Potatoes("Картошка1", 10, 2, 50);
            double expected = potatoes;
            Assert.AreEqual(expected, 10.2);
        }
        [TestMethod]
        public void TestException()
        {
            Food potatoes = new Potatoes("Картошка1", 10, 2, 50);
            double expected = potatoes;
            Assert.AreEqual(expected, 10.2);
        }
    }
}
