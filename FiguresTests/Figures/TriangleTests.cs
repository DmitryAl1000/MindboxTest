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
        public void CalcArea_UseABC345_GetS_6()
        {
            //arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;

            double expectedSquare = 6;
            //act
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            var squere = triangle.CalcArea();

            //assert
            Assert.AreEqual(expectedSquare, squere);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CalcArea_UseNegativeNums_GetExeption()
        {
            //arrange
            double sideA = - 3;
            double sideB = - 4;
            double sideC = - 5;

            //act
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            var squere = triangle.CalcArea();

            //assert
            Assert.Fail();
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CalcArea_UseZero_GetExeption()
        {
            //arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 0;

            //act
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            var squere = triangle.CalcArea();

            //assert
            Assert.Fail();
        }






    }
}