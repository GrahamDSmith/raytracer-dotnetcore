using Xunit;
using RayTracer.Library;

namespace RayTracer.UnitTests
{
    public class PointTests
    {
        [Fact]
        public void Point_Creates_Tuples_With_W_Equals_1()
        {
            //Given
            var p = new Point(4, -4, 3);
            var t = new Tuple(4, -4, 3, 1.0);

            //Then
            Assert.Equal(t, p);
            Assert.Equal(p, t);
        }
    }
}
