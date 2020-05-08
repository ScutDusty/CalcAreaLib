using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcAreaLib.Test
{
    [TestClass]
    public class CalcAreaLibTests
    {
        [TestMethod]
        public void triangArea_a3b4c5_area6()
        {
            //arange
            double a = 4;
            double b = 3;
            double c = 5;
            string expected = "6";

            //act
            Figure _triangle = new Triangle(a,b,c);
            string actual = _triangle.Area();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void triangName_a3b4c5_rectangular()
        {
            //arange
            double a = 3;
            double b = 4;
            double c = 5;
            string expected = "Rectangular Triangle";

            //act
            Figure _triangle = new Triangle(a, b, c);
            string actual = _triangle.FigureName();
            
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void circleArea_rad5_appr78()
        {
            //arange
            double rad = 5;

            string expected = "78,5398163397448";

            //act
            Figure _circle = new Circle(rad);
            string actual = _circle.Area();

            //assert
            Assert.AreEqual(expected, actual);
        }






    }
}
