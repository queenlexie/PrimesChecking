using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;

namespace PrimesCalculator.Tests
{
    [TestClass()]
    public class FermatPseudoprimeTestTests{

        [TestMethod()]
        public void IsProbablyPseudoprimeTest(){
            var testUnderTest = new FermatPseudoprimeTest(10);
            Assert.IsTrue(testUnderTest.IsPrime(561));
        }

        [TestMethod()]
        public void IsProbablyNotPseudoprimeforPrimesTest(){
            var testUnderTest = new FermatPseudoprimeTest(10);
            Assert.IsFalse(testUnderTest.IsPrime(13));
        }

        [TestMethod()]
        public void IsProbablyNotPseudoprimeForCompositeTest(){
            var testUnderTest = new FermatPseudoprimeTest(10);
            Assert.IsFalse(testUnderTest.IsPrime(15));
        }
    }
}
