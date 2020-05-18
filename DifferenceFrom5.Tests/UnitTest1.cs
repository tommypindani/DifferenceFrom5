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
            var differenceFrom5 = NumberUtility.CalculateDifferenceFrom5(2);
            Assert.AreEqual(3, differenceFrom5);
        }

        [TestMethod]
        public void IfInputIs3Return2()
        {
            var differenceFrom5 = NumberUtility.CalculateDifferenceFrom5(3);
            Assert.AreEqual(2, differenceFrom5);
        }

        [TestMethod]
        public void IfInputIs2Return3()
        {
            var differenceFrom5 = NumberUtility.CalculateDifferenceFrom5(4);
            Assert.AreEqual(1, differenceFrom5);
        }

        [TestMethod]
        public void IfInputIs4Return4()
        {
            var differenceFrom5 = NumberUtility.CalculateDifferenceFrom5(5);
            Assert.AreEqual(0, differenceFrom5);
        }

        [TestMethod]
        public void IfInputIs4Return5()
        {
            var differenceFrom5 = NumberUtility.CalculateDifferenceFrom5(2);
            Assert.AreEqual(3, differenceFrom5);
        }
    }
}
