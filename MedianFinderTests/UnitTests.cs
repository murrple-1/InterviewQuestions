using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Roadrunner.Interview.MedianFinder;

namespace Roadrunner.Interview.MedianFinder.Test
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestEasy1()
        {
            int[] data = { 1, 2, 3 };
            int median = MedianFinder.FindMedian(data);
            Assert.AreEqual(2, median);
        }

        [TestMethod]
        public void TestEasy2()
        {
            int[] data = { 1, 2, 3, 4 };
            int median = MedianFinder.FindMedian(data);
            Assert.AreEqual(3, median);
        }

        [TestMethod]
        public void TestMedium1()
        {
            int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int median = MedianFinder.FindMedian(data);
            Assert.AreEqual(5, median);
        }

        [TestMethod]
        public void TestMedium2()
        {
            int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int median = MedianFinder.FindMedian(data);
            Assert.AreEqual(6, median);
        }

        [TestMethod]
        public void TestMedium3()
        {
            int[] data = { 5, 2, 11, 4, 2, 6, 7, 10, 2 };
            int median = MedianFinder.FindMedian(data);
            Assert.AreEqual(5, median);
        }

        [TestMethod]
        public void TestHard1()
        {
            int[] data = { 154, 61, 741, 239, 467, 233, 126, 971, 368, 325, 56, 266, 958, 763, 652, 565, 92, 610, 237, 655, 688, 923, 569, 709, 298, 878, 766, 954, 836, 468, 77, 507, 327, 509, 739, 719, 176, 380, 961, 18, 635, 891, 440, 105, 862, 986, 666, 797, 109, 830, 265, 133, 594, 208, 353, 235, 135, 261, 520, 74, 710, 240, 32, 340, 65, 370, 98, 734, 1, 990, 398, 273, 96, 863, 846, 470, 833, 2, 252, 97, 326, 787, 619, 903, 839, 822, 284, 142, 257, 657, 824, 36, 609, 663, 158, 342, 375, 872, 189, 496 };
            int median = MedianFinder.FindMedian(data);
            Assert.AreEqual(467, median);
        }
    }
}
