using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Work_for_unit_test;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2, Program.work_with_file());
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(Program.MethodTrue());
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsFalse(Program.MethodFalse());
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsNotNull(Program.MethodFalse());
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.IsNull(Program.MethodNull());
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.IsNotNull(Program.work_with_file());
        }

        //[TestMethod]
        //public void TestMethod7()
        //{
        //    Assert.ThrowsException(Program.MethodArray());
        //}
        [TestMethod]
        public void TestMethod8()
        {
            Assert.AreNotEqual(3,Program.work_with_file());
        }
        [TestMethod]
        public void TestMethod9()
        {
            Assert.IsInstanceOfType(Program.work_with_file(), typeof(int));
        }
        public void TestMethod10()
        {
            Assert.IsNotInstanceOfType(Program.work_with_file(), typeof(double));
        }

    }
}
