using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimesCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrimesCalculator.Tests
{
    [TestClass()]
    public class MillerRabinTestTests
    {
        [TestMethod()]
        public void IsProbablyPrimeTest()
        {
            Assert.IsTrue(MillerRabinTest.isPrime(37, 10));
        }
        [TestMethod()]
        public void IsProbablyCompositeTest()
        {
            Assert.IsFalse(MillerRabinTest.isPrime(50, 10));
        }
    }
}