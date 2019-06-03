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
    }
}
