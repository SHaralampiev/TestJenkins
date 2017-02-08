using System;
using System.Collections.Generic;
using System.Drawing;
using ConsoleTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod()
        {
            var labirint = new int[5, 5]
            {
                {0, 1, 1, 1, 1},
                {0, 0, 1, 1, 1},
                {1, 0, 1, 1, 1},
                {0, 0, 1, 1, 1},
                {2, 1, 1, 1, 1}
            };

            var expectedResult = new List<Point[]>()
            {
                new Point[7]
                {
                    new Point() {X = 0, Y = 0},
                    new Point() {X = 1, Y = 0},
                    new Point() {X = 1, Y = 1},
                    new Point() {X = 2, Y = 1},
                    new Point() {X = 3, Y = 1},
                    new Point() {X = 3, Y = 0},
                    new Point() {X = 4, Y = 0}
                }
            };

            var actual = DFSearch.Search(labirint, new Point() { X = 0, Y = 0 });

            for (int i = 0; i < expectedResult.Count; i++)
            {
                CollectionAssert.AreEqual(expectedResult[i], actual[i]);
            }

            Assert.IsTrue(expectedResult.Count == actual.Count);
        }
    }
}
