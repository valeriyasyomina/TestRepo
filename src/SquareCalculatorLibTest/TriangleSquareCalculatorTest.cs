using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareCalculatorLib.TriangleSquareCalculator;
using SquareCalculatorLib.Interface;

namespace SquareCalculatorLibTest
{
    [TestClass]
    public class TriangleSquareCalculatorTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDeron1()
        {
            //range
            ITriangleSquareCalculator geron = new Geron();

            //act
            double square = geron.Calculate(0, 2, 10);      
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDeron2()
        {
            //range
            ITriangleSquareCalculator geron = new Geron();

            //act
            double square = geron.Calculate(3, 0, 10);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDeron3()
        {
            //range
            ITriangleSquareCalculator geron = new Geron();

            //act
            double square = geron.Calculate(5, 9, 0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDeron4()
        {
            //range
            ITriangleSquareCalculator geron = new Geron();

            //act
            double square = geron.Calculate(10, 3, 15);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDeron5()
        {
            //range
            ITriangleSquareCalculator geron = new Geron();

            //act
            double square = geron.Calculate(15, 3, 10);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDeron6()
        {
            //range
            ITriangleSquareCalculator geron = new Geron();

            //act
            double square = geron.Calculate(3, 10, 15);
        }
        [TestMethod]     
        public void TestDeron7()
        {
            //range
            ITriangleSquareCalculator geron = new Geron();

            //act
            double square = geron.Calculate(3, 4, 5);

            //assert
            Assert.AreEqual(square, 6.0);
        }
        [TestMethod]
        public void TestDeron8()
        {
            //range
            ITriangleSquareCalculator geron = new Geron();

            //act
            double square = geron.Calculate(100, 87, 75);
            
            //assert
            Assert.IsTrue(Math.Abs(square - 3163.2742) < 1e-3);
        }
    }
}
