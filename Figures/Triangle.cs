using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Triangle : IFigure
    {
        #region Properties

        private double sideA;
        /// <summary>
        /// First triangle side
        /// </summary>
        /// <exception cref="ArgumentException">Side must be more then zero</exception>
        public double SideA
        {
            get { return sideA; }
            private set { _ = sideA > 0 ? sideA = value : throw new ArgumentException("Side must be more then zero"); }
        }

        private double sideB;
        /// <summary>
        /// Second triangle side
        /// </summary>
        /// <exception cref="ArgumentException">Side must be more then zero</exception>
        public double SideB
        {
            get { return sideB; }
            private set { _ = sideB > 0 ? sideB = value : throw new ArgumentException("Side must be more then zero"); }
        }

        private double sideC;
        /// <summary>
        /// Third triangle side
        /// </summary>
        /// <exception cref="ArgumentException">Side must be more then zero</exception>
        public double SideC
        {
            get { return sideC; }
            private set { _ = sideC > 0 ? sideC = value : throw new ArgumentException("Side must be more then zero"); }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Triangle constructor
        /// </summary>
        /// <param name="sideA">First side</param>
        /// <param name="sideB">Seond side</param>
        /// <param name="sideC">Third side</param>
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            if (!IsRightTriangle()) throw new Exception("Sum of two triangle sides must be more then third");
        }

        #endregion

        #region Methods

        /// <summary>
        /// Triangle perimeter finder
        /// </summary>
        /// <returns>Perimeter</returns>
        public double PerimeterFinder()
        {
            return sideA + sideB + sideC;
        }
        /// <summary>
        /// Triangle square finder
        /// </summary>
        /// <returns>Square</returns>
        public double SquareFinder()
        {
            double p = PerimeterFinder() / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }

        /// <summary>
        /// Sum of two triangle sides must be more then third
        /// </summary>
        /// <returns>Return true if triangle is right</returns>
        private bool IsRightTriangle()
        {
            if (sideA + sideB > sideC || sideA + sideC > sideB || sideB + sideC > sideA)
                return true;
            return false;
        }

        public bool IsRectangularTriangle()
        {
            
            return false;
        }

        #endregion
    }
}
