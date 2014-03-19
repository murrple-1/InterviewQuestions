using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Roadrunner.Interview.Skyline;

namespace Roadrunner.Interview.Skyline.Test
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestEmpty()
        {
            IList<Tuple<Skyline.Vector, Skyline.Vector>> input = new List<Tuple<Skyline.Vector, Skyline.Vector>>();
            IList<Skyline.Vector> output = Skyline.Rasterize(input);

            Assert.AreEqual(0, output[0].X);
            Assert.AreEqual(0, output[0].Y);
        }

        [TestMethod]
        public void TestSingle()
        {
            IList<Tuple<Skyline.Vector, Skyline.Vector>> input = new List<Tuple<Skyline.Vector, Skyline.Vector>>();
            Tuple<Skyline.Vector, Skyline.Vector> t = Tuple.Create<Skyline.Vector, Skyline.Vector>(new Skyline.Vector() { X = 1, Y = 3 }, new Skyline.Vector() { X = 4, Y = 3 });
            input.Add(t);
            IList<Skyline.Vector> output = Skyline.Rasterize(input);
            Assert.IsTrue(output.Count == 3);

            Assert.AreEqual(1, output[0].X);
            Assert.AreEqual(0, output[0].Y);

            Assert.AreEqual(0, output[1].X);
            Assert.AreEqual(3, output[1].Y);

            Assert.AreEqual(3, output[2].X);
            Assert.AreEqual(0, output[2].Y);
        }

        [TestMethod]
        public void TestMulti()
        {
            IList<Tuple<Skyline.Vector, Skyline.Vector>> input = new List<Tuple<Skyline.Vector, Skyline.Vector>>();
            Tuple<Skyline.Vector, Skyline.Vector> t = Tuple.Create<Skyline.Vector, Skyline.Vector>(new Skyline.Vector() { X = 1, Y = 3 }, new Skyline.Vector() { X = 4, Y = 3 });
            input.Add(t);
            t = Tuple.Create<Skyline.Vector, Skyline.Vector>(new Skyline.Vector() { X = 6, Y = 3 }, new Skyline.Vector() { X = 9, Y = 3 });
            input.Add(t);
            t = Tuple.Create<Skyline.Vector, Skyline.Vector>(new Skyline.Vector() { X = 2, Y = 7 }, new Skyline.Vector() { X = 3, Y = 7 });
            input.Add(t);
            //    _
            //   | |
            //   | |
            //   | |
            //  _| |_    ___
            // |     |  |   
            // |     |  |
            //_|     |__|
            IList<Skyline.Vector> output = Skyline.Rasterize(input);

            Assert.AreEqual(1, output[0].X);
            Assert.AreEqual(0, output[0].Y);

            Assert.AreEqual(0, output[1].X);
            Assert.AreEqual(3, output[1].Y);

            Assert.AreEqual(1, output[2].X);
            Assert.AreEqual(0, output[2].Y);

            Assert.AreEqual(0, output[3].X);
            Assert.AreEqual(4, output[3].Y);

            Assert.AreEqual(1, output[4].X);
            Assert.AreEqual(0, output[4].Y);

            Assert.AreEqual(0, output[5].X);
            Assert.AreEqual(-4, output[5].Y);

            Assert.AreEqual(1, output[6].X);
            Assert.AreEqual(0, output[6].Y);

            Assert.AreEqual(0, output[7].X);
            Assert.AreEqual(-3, output[7].Y);

            Assert.AreEqual(2, output[8].X);
            Assert.AreEqual(0, output[8].Y);

            Assert.AreEqual(0, output[9].X);
            Assert.AreEqual(3, output[9].Y);

            Assert.AreEqual(3, output[10].X);
            Assert.AreEqual(0, output[10].Y);
        }
    }
}
