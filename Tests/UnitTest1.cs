using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prudish;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var cleaner = new Cleaner();
            var result = cleaner.Simplify(@"|-|3110 |/\|O|?1|)");
            Assert.AreEqual("heloworld", result);
        }
    }
}
