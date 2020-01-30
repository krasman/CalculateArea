using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace FigureArea
{
    
    class Test
    {
        IAreable triangle = new Triangle(3, 4, 5);
        IAreable circle = new Circle(5);
        IAreable triangle2 = new Triangle(4, 5, 6);
        [Test]
        public void TestAreas()
        {
            Assert.AreEqual(triangle.CalculateArea(), 6);
            Assert.AreEqual(circle.CalculateArea(), 78.5398, 0.0001);
        }
        public void TestRectangularity()
        {
            Assert.AreEqual(((Triangle)triangle).IsRectangular(), true);
            Assert.AreEqual(((Triangle)triangle2).IsRectangular(), false);
        }
    }
}
