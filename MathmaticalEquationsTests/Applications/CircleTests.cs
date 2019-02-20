using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MathmaticalEquations.Tests
{
    [TestClass()]
    public class CircleTests
    { 
        [TestMethod()]
        public void CircleTest()
        {
            var circle = new Circle(2);

            Assert.AreEqual(12.56, circle.Area, 0.01);
            Assert.AreEqual(12.56, circle.Circumference, 0.01);
        }
    }
}