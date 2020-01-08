using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimesCalculator;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Sdk;

namespace PrimesCalculator.Tests
{
    [TestClass()]
    public class FermatPseudoprimeTestTests
    {
        [TestMethod()]
        public void IsProbablyPseudoprimeTest()
        {
            Assert.IsTrue(FermatPseudoprimeTest.Check(561, 10));
        }
        [TestMethod()]
        public void IsProbablyNotPseudoprimeforPrimesTest()
        {
            Assert.IsFalse(FermatPseudoprimeTest.Check(13, 10));
        }
        [TestMethod()]
        public void IsProbablyNotPseudoprimeForCompositeTest()
        {
            Assert.IsFalse(FermatPseudoprimeTest.Check(15, 10));
        }
    }
}
