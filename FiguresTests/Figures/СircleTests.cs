using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figures.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Figures.Tests
{
    [TestClass()]
    public class СircleTests
    {

        [TestMethod()]
        public void GetSquareTest_UseR10_GETResultS314()
        {
            //arrange
            double r = 10;
            double expectedSquare = 314.16;

            //act
            var circle = new Сircle(r);
            var squere = circle.CalcArea();
            squere = Math.Round(squere, 2);

            //assert
            Assert.AreEqual(expectedSquare, squere);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void GetSquareTest_UseNegavieValue_GetEeption()
        {
            //arrange
            double r = -300.4;

            //act
            var circle = new Сircle(r);
            var squere = circle.CalcArea();

            //assert
            Assert.Fail();
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void GetSquareTest_UseZeroValue_GetEeption()
        {
            //arrange
            double r = 0;

            //act
            var circle = new Сircle(r);
            var squere = circle.CalcArea();

            //assert
            Assert.Fail();
        }

    }
}