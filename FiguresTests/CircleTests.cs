using Figures;
using System;
using Xunit;

namespace FiguresTests
{
    public class CircleTests
    {
        [Fact]
        public void CircleZeroRadiusConstructorTest()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0));
        }

        [Fact]
        public void CircleBelowZeroRadiusConstructorTest()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-5.5));
        }

        [Fact]
        public void PerimeterFinderTest() 
        {
            Circle circle = new Circle(5);
            Assert.Equal(31.41592653589793, circle.PerimeterFinder());
        }

        [Fact]
        public void SquareFinderTest()
        {
            Circle circle = new Circle(5);
            Assert.Equal(78.53981633974483, circle.SquareFinder());
        }
    }
}
