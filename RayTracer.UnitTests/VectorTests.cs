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
    }
}
