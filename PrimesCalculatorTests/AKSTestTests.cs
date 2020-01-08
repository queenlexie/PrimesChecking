using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimesCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrimesCalculator.Tests
{
    [TestClass()]
    public class AKSTestTests
    {
        [TestMethod()]
        public void IsProbablyPrimeTest()
        {
            Assert.IsTrue(AKSTest.isPrime(37));
        }
        [TestMethod()]
        public void IsProbablyCompositeTest()
        {
            Assert.IsFalse(AKSTest.isPrime(50));
        }
    }
}