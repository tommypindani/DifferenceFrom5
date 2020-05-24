using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DifferenceFrom5.Tests
{
    [TestClass]
    public class DifferenceFrom5
    {
        [TestMethod]
        public void IfInputIsPooReturn0()
        {
            var differenceFrom5 = NumberUtility.CalculateDifferenceFrom5(1);
            Assert.AreEqual(4, differenceFrom5);
        }

        [TestMethod]
        public void IfInputIs4Return1()
        {
            var differenceFrom5 = NumberUtility.CalculateDifferenceFrom5(4);
            Assert.AreEqual(1, differenceFrom5);
        }
        [TestMethod]
        public void DifferenceFrom5_IsValidNumber()
        {
            var differenceFrom5 = 0 < 5;
            Assert.IsTrue(0 < 5);
        }


        [TestMethod]
        public void DifferenceFrom5_IsInvalidNumber()
        {
            var differenceFrom5 = false;

            Assert.ThrowsException<System.ApplicationException>( DifferenceFrom5_IsInvalidNumber);
        }
    }
}
