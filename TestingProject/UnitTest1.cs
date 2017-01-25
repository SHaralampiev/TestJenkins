using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod()
        {
            Assert.AreEqual(1, 1);
        }

        /// <summary>
        /// Test Method
        /// </summary>
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(1, 2);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
