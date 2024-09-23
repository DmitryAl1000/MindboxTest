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
        public void GetSquareTest()
        {
            //arrange
            double x = 3;
            double y = 4;
            double z = 5;

            double expectedSquare = 6;
            //act
            Triangle triangle = new Triangle();
            var squere = triangle.GetSquare(x, y, z);


            //assert
            Assert.AreEqual(expectedSquare, squere);
        }
    }
}