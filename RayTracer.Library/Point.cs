using System;
using System.Collections.Generic;
using System.Text;

namespace RayTracer.Library
{
    public class Point : Tuple
    {
        public Point(double x, double y, double z) : base(x, y, z, 1) { }
    }
}
