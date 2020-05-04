﻿using Discriminant_dll;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscriminantDll_Tests
{
    [TestClass]
    public class MSUnitTestsRoots
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
        public void Test_Discriminant_1_10_1()
        {
            double a = 1;
            double b = 10;
            double c = 1;

            var d = _discriminant.CalculationDiscriminant(a, b, c);
            
            Assert.IsTrue(d.x1<0, d.x1.ToString());
            Assert.IsTrue(d.x2<0, d.x2.ToString());
        }
    }
}
