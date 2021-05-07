using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MTD_Laba_3;

namespace UnitTestMTD_Laba_3
{
    [TestClass]
    public class UnitTest1
    {
        Singleton one;
        Singleton two;
        
        [TestMethod]
        public void TestForWriteNumber()
        {
            var l1 = Singleton.GetInstance();
            var actual = l1.WriteNumber(27);
            var expected = " 20";
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
            var thread1 = new Thread(FirstThreadEntryPoint);
            var thread2 = new Thread(SecondThreadEntryPoint);
            thread1.Start();
            thread2.Start();
            var actual = one.WriteNumber(20);
            var expected = two.WriteNumber(24);
            Assert.AreEqual(one, two);
        }
        public void FirstThreadEntryPoint()
        {
            one = Singleton.GetInstance();
        }
        public void SecondThreadEntryPoint()
        {
            two = Singleton.GetInstance();
        }
    }
}
