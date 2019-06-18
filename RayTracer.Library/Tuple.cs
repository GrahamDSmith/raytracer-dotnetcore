﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RayTracer.Library
{
    public class Tuple
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double W { get; set; }

        public Tuple(double x, double y, double z, double w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;

        }

        public TupleType Type
        {
            get
            {
                if (W == 1.0)
                { return TupleType.Point; }
                if (W == 0.0)
                { return TupleType.Vector; }
                return TupleType.Undefined;
            }
        }

        public override bool Equals(object obj)
        {
            Tuple t = obj as Tuple;
            Tuple self = this as Tuple;
            if (t == null || self == null)
            {
                return false;
            }
            else
            {
                return (t.X.Equals(self.X)
                    && t.Y.Equals(self.Y)
                    && t.Z.Equals(self.Z)
                    && t.W.Equals(self.W));
            }
        }

        public Tuple Add(Tuple other)
        {
            return new Tuple(X + other.X, Y + other.Y, Z + other.Z, W + other.W);
        }

        public Tuple Subtract(Tuple other)
        {
            return new Tuple(X - other.X, Y - other.Y, Z - other.Z, W - other.W);
        }

        public Tuple Negate()
        {
            return new Tuple(-X, -Y, -Z, -W);
        }

        public Tuple Multiply(double multiplier)
        {
            return new Tuple(X * multiplier, Y * multiplier, Z * multiplier, W * multiplier);
        }

        public Tuple Divide(double divisor)
        {
            return new Tuple(X / divisor, Y / divisor, Z / divisor, W / divisor);
        }

        public double Magnitude()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));
        }

        public Tuple Normalize()
        {
            var m = this.Magnitude();
            return this.Divide(m);
        }

        public double Dot(Tuple other)
        {
            return 
                X * other.X + 
                Y * other.Y + 
                Z * other.Z + 
                W * other.W;
        }
    }

    public enum TupleType
    {
        Undefined,
        Vector,
        Point
    }

}
