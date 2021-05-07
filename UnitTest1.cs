using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MTD_Laba_3;

namespace UnitTestMTD_Laba_3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForWriteNumber()
        {
            var l1 = Singleton.GetInstance();
            var actual = l1.WriteNumber(25);
            var expected = " 27";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForGetInstance()
        {
            var l1 = Singleton.GetInstance();
            var l2 = Singleton.GetInstance();
            var actual = l1;
            var expected = l2;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestForMultithreading()
        {
            var l1 = Singleton.GetInstance();
            var l2 = Singleton.GetInstance();
            var actual = l1.WriteNumber(27);
            var expected = l2.WriteNumber(18);
            Assert.AreEqual(expected, actual);
        }
    }
}
