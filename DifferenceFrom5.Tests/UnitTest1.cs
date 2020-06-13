using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DifferenceFrom5.Tests
{
    [TestClass]
    public class DifferenceFrom5
    {
        [TestMethod]
        public void DifferenceFrom5_1_Return_4()
        {
            var differenceFrom5 = NumberUtility.CalculateDifferenceFrom5(1);
            Assert.AreEqual(4, differenceFrom5);
        }

        [TestMethod]
        public void DifferenceFrom5_4_Return_1() 
        {
            var differenceFrom5 = NumberUtility.CalculateDifferenceFrom5(4);
            Assert.AreEqual(1, differenceFrom5);
        }

        [TestMethod]
        public void DifferenceFrom5_IsInvalidNumber()
        {
            Assert.ThrowExpection<ArgumentExpection>(() => (NumberUtility.CalculateDifferenceFrom5("ArgumentExpection input"));
        }

        }
    }

