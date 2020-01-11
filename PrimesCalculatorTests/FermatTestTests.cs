using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;

namespace PrimesCalculator.Tests
{
    [TestClass()]
    public class FermatTestTests{
        [TestMethod()]
        public void IsProbablyPrimeTest(){
            var testUnderTest = new FermatTest(10);
            Assert.IsTrue(testUnderTest.IsPrime(37));
        }

        [TestMethod()]
        public void IsProbablyCompositeTest(){
            var testUnderTest = new FermatTest(10);
            Assert.IsFalse(testUnderTest.IsPrime(50));
        }
    }
}