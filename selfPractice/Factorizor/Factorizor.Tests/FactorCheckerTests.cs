using Factorizor.BLL;
using Factorizor.Models;
using NUnit.Framework;

namespace Factorizor.Tests
{
    [TestFixture]
    public class FactorCheckerTests
    {
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        public void CheckFactorsReturnsNumberPassed(int number, int expected)
        {
            FactorChecker fc = new FactorChecker();

            FactorResult result = fc.CheckFactors(number);
            int actual = result.Number;

            Assert.AreEqual(expected, actual);

        }

        [TestCase(6, new int[] { 1, 2, 3 }, true, false)]
        [TestCase(13, new int[] { 1 }, false, true)]
        public void TestFactors(int number, int[] factors, bool perfect, bool prime)
        {
            FactorChecker checker = new FactorChecker();

            FactorResult result = checker.CheckFactors(number);

            Assert.AreEqual(factors, result.Factors);
            Assert.AreEqual(perfect, result.IsPerfect);
            Assert.AreEqual(prime, result.IsPrime);
        }
    }
}
