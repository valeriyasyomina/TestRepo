using SquareCalculatorLib.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculatorLib.TriangleSquareCalculator
{
    public class Geron : ITriangleSquareCalculator
    {
        /// <summary>
        /// Вычисление площади треугольника по формуле Герона
        /// </summary>
        /// <param name="firstSide">Первая торона</param>
        /// <param name="secondSide">2 сторона</param>
        /// <param name="thirdSide">3 сторона</param>
        /// <returns>Площадь</returns>
        public double Calculate(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0)
                throw new ArgumentException("Error 1st side value");
            if (secondSide <= 0)
                throw new ArgumentException("Error 2nd side value");
            if (thirdSide <= 0)
                throw new ArgumentException("Error 3rd side value");
            if (firstSide > secondSide + thirdSide || secondSide > firstSide + thirdSide ||
                thirdSide > firstSide + secondSide)
                throw new ArgumentException("Triangle with such sides does not exist");
    
            double perimeterHalf = CalculatePerimeterHalf(firstSide, secondSide, thirdSide);
            return Math.Sqrt(perimeterHalf * (perimeterHalf - firstSide) * (perimeterHalf - secondSide) * (perimeterHalf - thirdSide));
        }
        /// <summary>
        /// Вычисление полупериметра треугольника
        /// </summary>
        /// <param name="firstSide">1 сторона</param>
        /// <param name="secondSide">2 сторона</param>
        /// <param name="thirdSide">3 сторона</param>
        /// <returns>Полупериметр</returns>
        protected double CalculatePerimeterHalf(double firstSide, double secondSide, double thirdSide)
        {
            return (firstSide + secondSide + thirdSide) / 2.0;
        }
    }
}
