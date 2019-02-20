using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathmaticalEquations.Tests
{
    [TestClass()]
    public class HemisphereTests
    {
        [TestMethod()]
        public void HemisphereTest()
        {
            var hemisphere = new Hemisphere(2);

            Assert.AreEqual(16.75, hemisphere.Volume, 0.01);
        }
    }
}