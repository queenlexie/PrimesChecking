using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimesCalculator.Tests{
    [TestClass()]
    public class MillerRabinTestTests{
        [TestMethod()]
        public void IsProbablyPrimeTest(){
            var testUnderTest = new MillerRabinTest(10);
            Assert.IsTrue(testUnderTest.IsPrime(37));
        }

        [TestMethod()]
        public void IsProbablyCompositeTest(){
            var testUnderTest = new MillerRabinTest(10);
            Assert.IsFalse(testUnderTest.IsPrime(50));
        }
    }
}