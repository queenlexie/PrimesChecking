using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimesCalculator;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Sdk;

namespace PrimesCalculator.Tests
{
    [TestClass()]
    public class FermatTestTests
    {
        [TestMethod()]
        public void IsProbablyPrimeTest()
        {
            Assert.IsTrue(FermatTest.IsProbablyPrime(37, 10));
        }
        [TestMethod()]
        public void IsProbablyCompositeTest()
        {
            Assert.IsFalse(FermatTest.IsProbablyPrime(50, 10));
        }

    }

}