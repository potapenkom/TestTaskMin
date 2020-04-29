using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskMin;

namespace TaskMinTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TriangleSquere_Lines_2_2_2()
        {
            //Arrange
            var triangle = new Triangle();

            //Act
            var result = triangle.Square(2.00,2.00, 2.00);

            //Assert
            var expectedResult = 1.7320508075688772;
            Assert.AreEqual(result, expectedResult);
        }
    }
}
