using System;
using System.Collections.Generic;
using System.Text;

namespace RayTracer.Library
{
    public class Vector : Tuple
    {
        public Vector(double x, double y, double z) : base(x, y, z, 0) { }

        public Vector Cross(Vector other)
        {
            return new Vector(
                Y * other.Z - Z * other.Y,
                Z * other.X - X * other.Z,
                X * other.Y - Y * other.X);
        }
    }
}
