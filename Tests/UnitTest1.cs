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
            var result = cleaner.Simplify(@"7|-|3 |=|31 15 93771|\|9 (|053 70 7|-|15 31337 0p3|24710|\|!");
        }
    }
}
