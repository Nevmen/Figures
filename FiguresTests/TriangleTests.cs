using Figures;
using System;
using Xunit;

namespace FiguresTests
{
    public class TriangleTests
    {
        [Fact]
        public void TriangleSideAZeroTest()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(0, 1, 5.4));
        }
        [Fact]
        public void TriangleSideBZeroTest()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 0, 5.4));
        }
        [Fact]
        public void TriangleSideCZeroTest()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(23, 14.6, 0));
        }
        [Fact]
        public void TriangleIsRightTriangleTest()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
        }
        [Fact]
        public void TrianglePerimeterFinderTest()
        {
            var triangle = new Triangle(3, 4, 5);
            double i = 12.0;
            Assert.Equal(i, triangle.PerimeterFinder());
        }
        [Fact]
        public void TriangleSquareFinderTest()
        {
            var triangle = new Triangle(10, 15, 6);
            Assert.Equal(20.123058912600737, triangle.SquareFinder());
        }
        [Fact]
        public void TriangleIsRectangularTriangleTest()
        {
            var triangle = new Triangle(10, 15, 6);
            var triangleRect = new Triangle(3, 4, 5);

            Assert.False(triangle.IsRectangularTriangle());
            Assert.True(triangleRect.IsRectangularTriangle());
        }
    }
}
