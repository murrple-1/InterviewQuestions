using System;
using System.Collections.Generic;

namespace Roadrunner.Interview.Skyline
{
    public class Skyline
    {
        public class Vector
        {
            public int X {get; set;}
            public int Y {get; set;}
        }

        public static IList<Vector> Rasterize(ICollection<Tuple<Vector, Vector>> input)
        {
            int width = 0;
            foreach (Tuple<Vector, Vector> t in input)
            {
                if (t.Item2.X > width)
                {
                    width = t.Item2.X;
                }
            }

            int[] heightMap = new int[width];
            for (int i = 0; i < heightMap.Length; i++)
            {
                heightMap[i] = 0;
            }
            foreach (Tuple<Vector, Vector> t in input)
            {
                for (int x = t.Item1.X; x < t.Item2.X; x++)
                {
                    if (heightMap[x] < t.Item1.Y)
                    {
                        heightMap[x] = t.Item1.Y;
                    }
                }
            }

            IList<Vector> retVal = new List<Vector>();
            int currentX = 0;
            int currentY = 0;
            for (int i = 0; i < heightMap.Length; i++)
            {
                if (currentY != heightMap[i])
                {
                    retVal.Add(new Vector() { X = i - currentX, Y = 0 });
                    retVal.Add(new Vector() { X = 0, Y = heightMap[i] - currentY });
                    currentX = i;
                    currentY = heightMap[i];
                }
            }
            retVal.Add(new Vector() { X = width - currentX, Y = 0 });
            return retVal;
        }
    }
}
