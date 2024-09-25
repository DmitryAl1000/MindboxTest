using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void GetSquare_UseABC345_GetS_6()
        {
            //arrange
            double a = 3;
            double b = 4;
            double c = 5;

            double expectedSquare = 6;
            //act
            Triangle triangle = new Triangle(a, b, c);
            var squere = triangle.CalcArea();

            //assert
            Assert.AreEqual(expectedSquare, squere);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void GetSquare_UseNegativeNums_GetExeption()
        {
            //arrange
            double a = - 3;
            double b = - 4;
            double c = - 5;

            //act
            Triangle triangle = new Triangle(a, b, c);
            var squere = triangle.CalcArea();

            //assert
            Assert.Fail();
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void GetSquare_UseZero_GetExeption()
        {
            //arrange
            double a = 3;
            double b = 4;
            double c = 0;

            //act
            Triangle triangle = new Triangle(a, b, c);
            var squere = triangle.CalcArea();

            //assert
            Assert.Fail();
        }






    }
}