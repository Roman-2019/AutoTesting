using Discriminant_dll;
using NUnit.Framework;

namespace NUnitTestProject
{
    public class NUnitTest
    {
        private Discriminant discriminant;
        [SetUp]
        public void Setup()
        {
            discriminant = new Discriminant();
        }

        [Test]
        [TestCase(1, 1, 1, -3)]
        [TestCase(0, 1, 1, 1)]
        [TestCase(0, 0, 1, 0)]
        [TestCase(1, 10, 1, 96)]
        [TestCase(10, 10, 1, 60)]
        public void TestDiscriminant(int a, int b, int c, int expect)
        {
            var d = discriminant.CalculationDiscriminant(a, b, c);

            Assert.AreEqual(expect, d.D);
        }
    }
}