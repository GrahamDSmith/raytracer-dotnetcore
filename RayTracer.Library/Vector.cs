using System;
using System.Collections.Generic;
using System.Text;

namespace RayTracer.Library
{
    public class Vector : Tuple
    {
        public Vector(double x, double y, double z) : base(x, y, z, 0) { }

        public double Magnitude()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));
        }
    }
}
