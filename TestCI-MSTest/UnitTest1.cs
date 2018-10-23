using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCI_MSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string temp = "kartik22";
            Assert.IsNotNull(temp);
        }
    }
}
