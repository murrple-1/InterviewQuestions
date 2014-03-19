using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Roadrunner.Interview.LispesqueParser;

namespace Roadrunner.Interview.LispesqueParser.Test
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestSimpleNumber()
        {
            string input = "5";
            int retVal = LispesqueParser.Parse(input);
            Assert.AreEqual(5, retVal);
        }

        [TestMethod]
        public void TestSimpleAddition()
        {
            string input = "+ 1 1";
            int retVal = LispesqueParser.Parse(input);
            Assert.AreEqual(2, retVal);
        }

        [TestMethod]
        public void TestSimpleSubtraction()
        {
            string input = "- 3 1";
            int retVal = LispesqueParser.Parse(input);
            Assert.AreEqual(2, retVal);
        }

        [TestMethod]
        public void TestSimpleMultiplication()
        {
            string input = "* 3 4";
            int retVal = LispesqueParser.Parse(input);
            Assert.AreEqual(12, retVal);
        }

        [TestMethod]
        public void TestSimpleDivision()
        {
            string input = "/ 12 3";
            int retVal = LispesqueParser.Parse(input);
            Assert.AreEqual(4, retVal);
        }

        [TestMethod]
        public void TestComplex()
        {
            string input = "/ - 30 5 + 1 * 2 2";
            int retVal = LispesqueParser.Parse(input);
            Assert.AreEqual(5, retVal);
        }
    }
}
