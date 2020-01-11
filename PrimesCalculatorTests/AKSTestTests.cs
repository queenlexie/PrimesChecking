using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimesCalculator.Tests{

    [TestClass()]
    public class AKSTestTests{
        private AKSTest testUnderTest;

        [TestInitialize()]
        public void initializeTestMembers(){
            testUnderTest = new AKSTest();
        }

        [TestMethod()]
        public void IsProbablyPrimeTest(){
            Assert.IsTrue(testUnderTest.IsPrime(37));
        }

        [TestMethod()]
        public void IsProbablyCompositeTest(){
            Assert.IsFalse(testUnderTest.IsPrime(50));
        }
    }
}