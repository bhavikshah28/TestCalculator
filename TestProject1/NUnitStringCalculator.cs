using NUnit.Framework;
using StringCalculator;
using System;

namespace TestProject1
{
    [TestFixture]
    public class TestStringCalculator
    {
        Calculator calc;

        #region Setup
        [SetUp]
        public void setup()
        {
            calc = new Calculator();
        }
        #endregion
        #region Testing Scenario

        /// <summary>
        /// Test Empty String
        /// </summary>
        [Test]
        public void TestEmptyString()
        {
            var result = calc.Add("");
            Assert.AreEqual(0, result);
        }

        /// <summary>
        /// Test Single Number
        /// </summary>
        [Test]
        public void TestAddSingleNumber()
        {
            var result = calc.Add("1");
            Assert.AreEqual(1, result);
        }

        /// <summary>
        /// Test Sum of Two Numbers
        /// </summary>
        [Test]
        public void TestAddSumOfTwoNumbers()
        {
            var result = calc.Add("7,8");
            Assert.AreEqual(15, result);
        }

        /// <summary>
        /// Test SUm of Two Larger Numbers
        /// </summary>
        [Test]
        public void TestAddSumOfTwoLargerNumbers_55()
        {
            var result = calc.Add("30,25");
            Assert.AreEqual(55, result);
        }

        /// <summary>
        /// Test New Line
        /// </summary>
        [Test]
        public void TestAddNewLine()
        {
            var result = calc.Add("\n");
            Assert.AreEqual(0, result);
        }

        /// <summary>
        /// Test sum of Two Number sperated by new line
        /// </summary>
        [Test]
        public void TestAddTwoNumberDelimiterofNewLine()
        {
            var result = calc.Add("4\n5");
            Assert.AreEqual(9, result);
        }

        /// <summary>
        /// Added custom delimiter of //X
        /// </summary>
        [Test]
        public void TestAddCustomDelimiter()
        {
            var result = calc.Add("//X\n5A1");
            Assert.AreEqual(6, result);
        }

        /// <summary>
        /// Added custom delimiter of //D
        /// </summary>
        [Test]
        public void TestAddCustomDelimiterLargerNumber()
        {
            var result = calc.Add("//D\n20B8");
            Assert.AreEqual(28, result);
        }

        /// <summary>
        /// Negative Number Test
        /// </summary>
        [Test]
        [Microsoft.VisualStudio.TestTools.UnitTesting.ExpectedException(typeof(ApplicationException))]
        public void TestSingleNegativeNumber()
        {
            var result = calc.Add("-1");
        }

        /// <summary>
        /// Multiple Negative Number Test
        /// </summary>
        [Test]
        [Microsoft.VisualStudio.TestTools.UnitTesting.ExpectedException(typeof(ApplicationException))]
        public void TestMultipleNegativeNumbers()
        {
            var result = calc.Add("-1,-2");
        }

        /// <summary>
        /// Test Max Number
        /// </summary>
        [Test]
        public void TestValidateMaxNumber()
        {
            var result = calc.Add("2,1001");
            Assert.AreEqual(2, result);
        }

        /// <summary>
        /// Test Multiple Character
        /// </summary>
        [Test]
        public void TestMultipleCharactersUsed()
        {
            var result = calc.Add("//[AB][bc]\n3AB2bc4");
            Assert.AreEqual(9, result);
        }
        #endregion
    }

}