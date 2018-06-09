using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        private Name _Name;

        public UnitTest1()
        {
            _Name = new Name();
        }

        [TestMethod]
        public void GetNameTest()
        {
            string myName = "Tom";
            var name = _Name.GetName(myName);
            // Assert.AreEqual(myName, name);
        }

        [TestMethod]
        public void SplitNameTest()
        {
            string myName = "Tom Nelson";
            List<string> expectedSplitName = new List<string> { "Tom", "Nelson" };
            var name = _Name.SplitName(myName);
            Assert.AreEqual(expectedSplitName[0], name[0]);
            Assert.AreEqual(expectedSplitName[1], name[1]);
        }

        [TestMethod]
        public void TestChecker()
        {
            Assert.AreEqual(true, _Name.CheckTest());
        }
    }
}