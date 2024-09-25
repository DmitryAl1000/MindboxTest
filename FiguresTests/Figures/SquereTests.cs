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
    public class SquereTests
    {
        [TestMethod()]
        public void CalcAreaTest_Use5_Get25()
        {
            //arrange
            double side = 5;
            double result = 25;

            //act
            var circle = new Squere(side);
            var squere = circle.CalcArea();

            //assert
            Assert.AreEqual(result, squere);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CalcAreaTest_UseZeroValue_GetEeption()
        {
            //arrange
            double side = 0;

            //act
            var circle = new Squere(side);
            var squere = circle.CalcArea();

            //assert
            Assert.Fail();
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CalcAreaeTest_UseNegavieValue_GetEeption()
        {
            //arrange
            double side = -300.4;

            //act
            var circle = new Squere(side);
            var squere = circle.CalcArea();

            //assert
            Assert.Fail();
        }
    }
}