using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace T
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void GetNameTest()
        {
            string myName = "Tom";
            //var name = GetName(myName);
            // Assert.AreEqual(myName, name);
        }

        [TestMethod]
        public void SplitNameTest()
        {
            string myName = "Tom Nelson";
            List<string> expectedSplitName = new List<string> { "Tom", "Nelson" };
            //var name = SplitNameTest(myName);
            //Assert.AreEqual(expectedSplitName[0], name[0]);
            // Assert.AreEqual(expectedSplitName[1], name[1]);
        }

        [TestMethod]
        public void TestChecker()
        {
            //Assert.AreEqual(true, CheckTest());
        }
    }
}