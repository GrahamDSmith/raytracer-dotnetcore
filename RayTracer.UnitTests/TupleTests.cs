using Xunit;
using RayTracer.Library;

namespace RayTracer.UnitTests
{
    public class TupleTests
    {
        [Fact]
        public void Tuple_With_W_Equals_1_Is_A_Point()
        {
            //Given
            var a = new Tuple(4.3, -4.2, 3.1, 1.0);

            //Then
            Assert.Equal(4.3, a.X);
            Assert.Equal(-4.2, a.Y);
            Assert.Equal(3.1, a.Z);
            Assert.Equal(1.0, a.W);

            Assert.Equal(TupleType.Point, a.Type);
            Assert.NotEqual(TupleType.Vector, a.Type);
        }

        [Fact]
        public void Tuple_With_W_Equals_0_Is_A_Vector()
        {
            //Given
            var a = new Tuple(4.3, -4.2, 3.1, 0.0);

            //Then
            Assert.Equal(4.3, a.X);
            Assert.Equal(-4.2, a.Y);
            Assert.Equal(3.1, a.Z);
            Assert.Equal(0.0, a.W);

            Assert.Equal(TupleType.Vector, a.Type);
            Assert.NotEqual(TupleType.Point, a.Type);
        }

        [Fact]
        public void Equality_Operator_Returns_True_When_Equal()
        {
            var a = new Tuple(4.3f, -4.2f, 3.1f, 0.0f);
            var b = new Tuple(4.3f, -4.2f, 3.1f, 0.0f);

            var ab = a.Equals(b);
            var ba = b.Equals(a);

            Assert.True(ab);
            Assert.True(ba);
        }

        [Fact]
        public void Equality_Operator_Returns_False_When_Not_Equal()
        {
            var a = new Tuple(4.3f, -4.1f, 3.1f, 0.0f);
            var b = new Tuple(4.3f, -4.2f, 3.1f, 0.0f);

            var ab = a.Equals(b);
            var ba = b.Equals(a);

            Assert.False(ab);
            Assert.False(ba);
        }

        [Fact]
        public void Can_Add_Tuples()
        {
            //Given
            var a1 = new Tuple(3, -2, 5, 1);
            var a2 = new Tuple(-2, 3, 1, 0);
            var expectedResult = new Tuple(1, 1, 6, 1);

            //Then
            var actualResult = a1.Add(a2);
            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void Subtracting_Points_Gives_Vector()
        {
            //Given
            var p1 = new Point(3, 2, 1);
            var p2 = new Point(5, 6, 7);
            var expectedResult = new Vector(-2, -4, -6);

            //Then
            var actualResult = p1.Subtract(p2);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void Subtracting_Vector_From_Point_Gives_Point()
        {
            //Given
            var p = new Point(3, 2, 1);
            var v = new Vector(5, 6, 7);
            var expectedResult = new Point(-2, -4, -6);

            //Then
            var actualResult = p.Subtract(v);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void Subtracting_Two_Vectors_Gives_Vector()
        {
            //Given
            var v1 = new Vector(3, 2, 1);
            var v2 = new Vector(5, 6, 7);
            var expectedResult = new Vector(-2, -4, -6);

            //Then
            var actualResult = v1.Subtract(v2);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void Subtractng_Zero_Tuple_From_Vector_Negates_Vector()
        {
            //Given
            var zero = new Vector(0, 0, 0);
            var v = new Vector(1, -2, 3);
            var expectedResult = new Vector(-1, 2, -3);

            //Then
            var actualResult = zero.Subtract(v);
            Assert.Equal(actualResult, expectedResult);
        }

        [Fact]
        public void Can_Negate_Tuple()
        {
            //Given
            var a = new Tuple(1, -2, 3, -4);
            var expectedResult = new Tuple(-1, 2, -3, 4);

            //Then
            var actualResult = a.Negate();
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void Can_Multiply_Tuple_By_Scalar_Amount()
        {
            //Given
            var a = new Tuple(1, -2, 3, -4);
            var expectedResult = new Tuple(3.5, -7, 10.5, -14);

            //Then
            var actualResult = a.Multiply(3.5);
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
