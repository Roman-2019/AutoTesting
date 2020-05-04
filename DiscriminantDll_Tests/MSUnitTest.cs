using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Discriminant_dll;

namespace DiscriminantDll_Tests
{
    [TestClass]
    public class MSUnitTest
    {
        Discriminant _discriminant;
        [TestInitialize]
        public void BeforeAll() 
        {
            _discriminant = new Discriminant();
        }

        [TestCleanup]
        public void AfterAll() 
        {
            _discriminant.Dispose();
        }

        [TestMethod]
        public void Test_Discriminant_1_1_1()
        {          
            double a = 1;
            double b = 1;
            double c = 1;

            var d = _discriminant.CalculationDiscriminant(a, b, c);

            Assert.AreEqual(-3,d.D);
        }

        [TestMethod]
        public void Test_Discriminant_0_1_1()
        {
            double a = 0;
            double b = 1;
            double c = 1;

            var d = _discriminant.CalculationDiscriminant(a, b, c);

            Assert.AreEqual(1, d.D);
        }

        [TestMethod]
        public void Test_Discriminant_0_0_1()
        {
            double a = 0;
            double b = 0;
            double c = 1;

            var d = _discriminant.CalculationDiscriminant(a, b, c);

            Assert.AreEqual(0, d.D);
        }

        [TestMethod]
        public void Test_Discriminant_1_10_1()
        {
            double a = 1;
            double b = 10;
            double c = 1;

            var d = _discriminant.CalculationDiscriminant(a, b, c);

            Assert.AreEqual(96, d.D);
        }

        [TestMethod]
        public void Test_Discriminant_10_10_1()
        {
            double a = 10;
            double b = 10;
            double c = 1;

            var d = _discriminant.CalculationDiscriminant(a, b, c);

            Assert.AreEqual(60, d.D);
        }

    }
}
