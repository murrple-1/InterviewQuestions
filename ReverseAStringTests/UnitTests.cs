using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Roadrunner.Interview.ReverseAString;

namespace Roadrunner.Interview.ReverseAString.Test
{
    [TestClass]
    public class UnitTests
    {
        private static readonly string inputStr = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

        [TestMethod]
        public void TestReverse()
        {
            char[] input = inputStr.ToCharArray();
            char[] expected = new char[input.Length];
            Array.Copy(input, expected, input.Length);
            Array.Reverse(expected);

            char[] retVal = ReverseAString.Reverse(input);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], retVal[i]);
            }
        }

        [TestMethod]
        public void TestReverseRecursive()
        {
            char[] input = inputStr.ToCharArray();
            char[] expected = new char[input.Length];
            Array.Copy(input, expected, input.Length);
            Array.Reverse(expected);

            char[] retVal = ReverseAString.ReverseRecursive(input);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], retVal[i]);
            }
        }
    }
}
