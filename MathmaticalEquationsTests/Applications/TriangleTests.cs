using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathmaticalEquations.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void TriangleTest()
        {
            var triangle = new Triangle(2, 2, 2);

            Assert.AreEqual(1.73, triangle.Area, 0.01);
        }
    }
}