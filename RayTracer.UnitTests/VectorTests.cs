using Xunit;
using RayTracer.Library;

namespace RayTracer.UnitTests
{
    public class VectorTests
    {
        [Fact]
        public void Vector_Creates_Tuples_With_W_Equals_0()
        {
            //Given
            var v = new Vector(4, -4, 3);
            var t = new Tuple(4, -4, 3, 0);

            //Then
            Assert.Equal(t, v);
            Assert.Equal(v, t);
        }

        [Theory]
        [InlineData(1,1,0,0)]
        [InlineData(1, 0, 1, 0)]
        [InlineData(1, 0, 0, 1)]
        public void Can_Compute_Magnitude(double expected, double x, double y, double z)
        {
            //Given
            var v = new Vector(x, y, z);

            //Then
            Assert.Equal(expected, v.Magnitude());
        }

        [Fact]
        public void Can_Compute_Magnitude_Root()
        {
            //Given
            var v = new Vector(1,2,3);
            var expected = System.Math.Sqrt(14);

            //Then
            Assert.Equal(expected, v.Magnitude());
        }

        [Fact]
        public void Can_Normalize_Basic()
        {
            //Given
            var v = new Vector(4, 0, 0);
            var expectedResult = new Vector(1, 0, 0);


            //Then
            Assert.Equal(expectedResult, v.Normalize());
        }

        [Fact]
        public void Can_Normalize_Advanced()
        {
            //Given
            var v = new Vector(1, 2, 3);
            var sq = System.Math.Sqrt(14);
            var expectedResult = new Vector(1 / sq, 2 / sq, 3 / sq);

            //Then
            Assert.Equal(expectedResult, v.Normalize());
        }

        [Fact]
        public void Magnitude_OfNormalized_Vector_Is_One()
        {
            //Given
            var v = new Vector(1, 2, 3);
            var expectedResult = 1;

            //When
            var norm = v.Normalize();

            //Then
            Assert.Equal(expectedResult, norm.Magnitude());
        }

        [Fact]
        public void Can_Calculate_Dot_ProductOf_Two_Tuples()
        {
            //Given
            var a = new Vector(1, 2, 3);
            var b = new Vector(2, 3, 4);

            //Then
            Assert.Equal(20, a.Dot(b));
        }

        [Fact]
        public void Can_Calculate_Cross_ProductOf_Two_Vectors()
        {
            //Given
            var a = new Vector(1, 2, 3);
            var b = new Vector(2, 3, 4);

            var expectedResult1 = new Vector(-1, 2, -1);
            var expectedResult2 = new Vector(1, -2, 1);

            //Then
            Assert.Equal(expectedResult1, a.Cross(b));
            Assert.Equal(expectedResult2, b.Cross(a));
        }
    }
}
