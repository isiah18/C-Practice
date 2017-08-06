using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using StringCalculatorKata;

namespace StringCalculatorKata.Tests
{
    [TestFixture]
    public class StringCalculatorTests
    {
        private StringCalculator _stringCalculator;

        [SetUp]
        public void BeforeEachTest()
        {
            _stringCalculator = new StringCalculator();
        }

        [Test]
        public void Add_EmptyStringReturnsZero()
        {
            int result = _stringCalculator.Add("");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Add_OneNumberReturnsTheNumber()
        {
            int result = _stringCalculator.Add("5");
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Add_TwoNumbersReturnsSumOfNumbers()
        {
            int result = _stringCalculator.Add("2,8");
            Assert.AreEqual(10, result);
        }

        [Test]
        public void Add_FiveNumbersReturnsSumOfNumbers()
        {
            int result = _stringCalculator.Add("1,2,3,4,5");
            Assert.AreEqual(15,result);
        }
    }
}
