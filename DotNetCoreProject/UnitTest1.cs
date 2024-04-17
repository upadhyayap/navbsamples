using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetCoreProject
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }


        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Console.WriteLine("ClassInitialize");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            Console.WriteLine("ClassCleanup");
        }

        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void TestMethod11()
        {
        }

        [TestMethod]
        public void TestMethod111()
        {
        }

        [TestMethod]
        public void TestMethod1111()
        {
            TestContext.WriteLine("This is a filing test");
            Assert.AreEqual(1, 0);
        }

        [TestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(2, 2, 4)]
        [DataRow(2, 3, 4)]
        public void TestMehtod4(int a, int b, int c)
        {
            TestContext.WriteLine("This is a dd test");
            Assert.AreEqual(a + b, c);  
        }
    }
}
