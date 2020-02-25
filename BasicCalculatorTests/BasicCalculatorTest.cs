using System;
using BasicCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace BasicCalculatorTests
{
    public class BasicCalculatorTest
    {
        private BasicCalculator.BasicCalculator calculator = new BasicCalculator.BasicCalculator();

        [TestMethod()]
        public void AddingTest()
        {
            Assert.AreEqual(3, calculator.Sum(1, 2));
        }
        public void AddingDoubleTest()
        {
            Assert.AreEqual(113.19M, calculator.Sum(78.98M, 34.21M));
        }
        public void AddingArrayTest()
        {
            int[] foo = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Assert.AreEqual(45, calculator.Sum(foo));
        }

        [TestMethod()]
        public void SubtractTest()
        {
            Assert.AreEqual(17, calculator.Subtract(24, 7));
        }

        [TestMethod()]
        public void MultiplicationTest()
        {
            Assert.AreEqual(7, calculator.Product(3.5M, 2));
        }

        [TestMethod()]
        public void QuotientTest()
        {
            Assert.AreEqual(32, calculator.Result(256, 8));
        }

        [TestMethod()]
        public void SquareRootTest()
        {
            Assert.AreEqual(16, calculator.SqaureRootofNumber(4));
        }

        [TestMethod()]
        public void ExponentTest()
        {
            Assert.AreEqual(64, calculator.PowerOf(4, 3));
        }
        
    }
}
