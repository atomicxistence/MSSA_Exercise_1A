using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathmaticalEquations.Tests
{
    [TestClass()]
    public class UnivariateTests
    {
        [TestMethod()]
        public void UnivariateTest()
        {
            var univariate = new Univariate(1, 6, 7);

            Assert.AreEqual(-1.58, univariate.FirstAnswer, 0.01);
            Assert.AreEqual(-4.41, univariate.SecondAnswer, 0.01);
        }
    }
}