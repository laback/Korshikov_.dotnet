using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FigureLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FireguresTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TrianglePerimeter()
        {
            double a = 3, b = 4, c = 5;
            Triangle triangle = new Triangle(a, b, c);
            double perimeter = triangle.perimeter;
            double expected = a + b + c;
            Assert.AreEqual(perimeter, expected);
        }
        [TestMethod]
        public void TriangleSquare()
        {
            double a = 3, b = 4, c = 5;
            Triangle triangle = new Triangle(a, b, c);
            double halfPerimeter = (a + b + c) / 2; 
            double square = triangle.square;
            double expected = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
            Assert.AreEqual(square, expected);
        }
        [TestMethod]
        public void RectanglePerimeter()
        {
            double a = 2, b = 4;
            Rectangle rectangle = new Rectangle(a, b);
            double perimeter = rectangle.perimeter;
            double expected = (a + b) * 2;
            Assert.AreEqual(perimeter, expected);
        }
        [TestMethod]
        public void RectangleSquare()
        {
            double a = 2, b = 4;
            Rectangle rectangle = new Rectangle(a, b);
            double square = rectangle.square;
            double expected = a * b;
            Assert.AreEqual(square, expected);
        }
        [TestMethod]
        public void CirclePerimeter()
        {
            double r = 3;
            Circle circle = new Circle(3);
            double perimeter = circle.perimeter;
            double expected = 2 * Math.PI * r;
            Assert.AreEqual(perimeter, expected);
        }
        [TestMethod]
        public void CircleSquare()
        {
            double r = 3;
            Circle circle = new Circle(3);
            double square = circle.square;
            double expected = Math.PI * r * r;
            Assert.AreEqual(square, expected);
        }
        [TestMethod]
        public void FileRead()
        {
            string path = Directory.GetCurrentDirectory() + @"\figure.txt";
            int expected = File.ReadAllLines(path).Length;
            Figure figure = new Figure();
            Assert.AreEqual(expected, figure.FileRead().Count);
        }
        [TestMethod]
        public void AveragePer()
        {
            Figure figure = new Figure();
            double expected = (18.84 + 12 + 26) / 4;
            List<string> lines = figure.FileRead();
            double test = figure.AveragePerimeter(lines);
            Assert.AreEqual(expected, Math.Round(test,2));
        }
        [TestMethod]
        public void Squares()
        {
            List<double> expectedList = new List<double>();
            expectedList.Add(6);
            expectedList.Add(5);
            expectedList.Add(28.27);
            expectedList.Add(6);
            double expected = Math.Round(expectedList.ToArray().Sum(),2);
            Figure figure = new Figure();
            List<string> lines = figure.FileRead();
            Dictionary<Type, double> testDictionary = figure.Squares(lines);
            double test = Math.Round(testDictionary.Values.Sum(),2);
            Assert.AreEqual(expected, test);
        }
        [TestMethod]
        public void MaxSquare()
        {
            double expected = 28.27;
            Figure figure = new Figure();
            double test = figure.MaxSquare();
            Assert.AreEqual(expected, Math.Round(test, 2));
        }
        [TestMethod]
        public void MaxPerByType()
        {
            Figure figure = new Figure();
            List<string> lines = figure.FileRead();
            Type test = figure.MaxPerByType();
            Assert.AreEqual(test, typeof(Circle));
        }
    }
}
