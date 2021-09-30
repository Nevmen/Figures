using System;

namespace Figures
{
    public class Circle : IFigure
    {
        #region Properties

        private double radius;

        /// <summary>
        /// Circle radius
        /// </summary>
        /// <exception cref="ArgumentException">Radius must be more then zero</exception>
        public double Radius
        {
            get { return radius; }
            private set { _ = value > 0 ? radius = value : throw new ArgumentException("Radius must be more then zero"); }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Circle constructor
        /// </summary>
        /// <param name="radius">Circle radius</param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        #endregion

        #region Methods
        /// <summary>
        /// Circle perimeter finder
        /// </summary>
        /// <returns>Perimeter</returns>
        public double PerimeterFinder()
        {
            return 2 * Math.PI * radius;
        }
        /// <summary>
        /// Circle square finder
        /// </summary>
        /// <returns>Square</returns>
        public double SquareFinder()
        {
            return Math.PI * radius * radius;
        }

        #endregion
    }
}
