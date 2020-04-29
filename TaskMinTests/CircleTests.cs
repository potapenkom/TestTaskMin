using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskMin;

namespace TaskMinTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Circle_Square_Radius_2_12()
        {
           // Arrange
            var circule = new Circle();

           // Act
            var result = circule.Square(2.12);

           // Assert
            double expectedResult = 14.12;
            Assert.AreEqual(result, expectedResult);
        }

    }
}
