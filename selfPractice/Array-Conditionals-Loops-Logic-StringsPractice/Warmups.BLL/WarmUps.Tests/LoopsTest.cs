using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Warmups.BLL;

namespace WarmUps.Tests
{
    [TestFixture]
    class LoopsTest
    {
        Loops obj;

        [SetUp]
        public void BeforeEachTest()
        {
            obj = new Loops();
        }

        [TestCase("Hi", 2, "HiHi")]
        [TestCase("Hi", 3, "HiHiHi")]
        [TestCase("Hi", 1, "Hi")]
        public void StringTimesTest(string s, int n, string expected)
        {
            string actual = obj.StringTimes(s, n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Chocolate", 2, "ChoCho")]
        [TestCase("Chocolate", 3, "ChoChoCho")]
        [TestCase("Abc", 3, "AbcAbcAbc")]
        public void FrontTimesTest(string s, int n, string expected)
        {
            string actual = obj.FrontTimes(s, n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("abcxx", 1)]
        [TestCase("xxx", 2)]
        [TestCase("xxxx", 3)]
        public void CountXXTest(string s, int expected)
        {
            int actual = obj.CountXX(s);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("axxbb", true)]
        [TestCase("axaxxax", false)]
        [TestCase("xxxxx", true)]
        public void DoubleXTest(string s, bool expected)
        {
            bool actual = obj.DoubleX(s);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Hello", "Hlo")]
        [TestCase("Hi", "H")]
        [TestCase("Heeololeo", "Hello")]
        public void EveryOtherTest(string s, string expected)
        {
            string actual = obj.EveryOther(s);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Code", "CCoCodCode")]
        [TestCase("abc", "aababc")]
        [TestCase("ab", "aab")]
        public void StringSplosionTest(string s, string expected)
        {
            string actual = obj.StringSplosion(s);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("hixxhi", 1)]
        [TestCase("xaxxaxaxx", 1)]
        [TestCase("axxxaaxx", 2)]
        public void CountLast2Test(string s, int expected)
        {
            int actual = obj.CountLast2(s);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[]{ 1, 2, 9}, 1)]
        [TestCase(new int[]{ 1, 9, 9}, 2)]
        [TestCase(new int[]{ 1, 9, 9, 3, 9}, 3)]
        public void Count9Test(int[] array, int expected)
        {
            int actual = obj.Count9(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {1, 2, 9, 3, 4}, true)]
        [TestCase(new int[] {1, 2, 3, 4, 9}, false)]
        [TestCase(new int[] {1, 2, 3, 4, 5}, false)]
        public void ArrayFront9Test(int[] intArray, bool expected)
        {
            bool actual = obj.ArrayFront9(intArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {1, 1, 2, 3, 1}, true)]
        [TestCase(new int[] {1, 1, 2, 4, 1}, false)]
        [TestCase(new int[] {1, 1, 2, 1, 2, 3}, true)]
        public void Array123Test(int[] intArray, bool expected)
        {
            bool actual = obj.Array123(intArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("xxcaazz", "xxbaaz", 3)]
        [TestCase("abc", "abc", 2)]
        [TestCase("abc", "axc", 0)]
        [TestCase("a", "a", 1)]
        public void SubStringMatchTest(string a, string b, int expected)
        {
            int actual = obj.SubStringMatch(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("xxHxix", "xHix")]
        [TestCase("abxxxcd", "abcd")]
        [TestCase("xabxxxcdx", "xabcdx")]
        public void StringXTest(string str, string expected)
        {
            string actual = obj.StringX(str);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("kitten", "kien")]
        [TestCase("kitten", "kien")]
        [TestCase("kitten", "kien")]
        public void AltPairsTest(string a, string expected)
        {
            string actual = obj.AltPairs(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("yakpak", "pak")]
        [TestCase("pakyak", "pak")]
        [TestCase("yak123ya", "123ya")]
        public void DoNotYakTest(string s, string expected)
        {
            string actual = obj.DoNotYak(s);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {6, 6, 2}, 1)]
        [TestCase(new int[] {6, 6, 2, 6}, 1)]
        [TestCase(new int[] {6, 7, 2, 6}, 1)]
        [TestCase(new int[] { 6, 1, 6, 6 }, 1)]
        public void Array667Test(int[] intArray, int expected)
        {
            int actual = obj.Array667(intArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {1, 1, 2, 2, 1}, true)]
        [TestCase(new int[] {1, 1, 2, 2, 2, 1}, false)]
        [TestCase(new int[] {1, 1, 1, 2, 2, 2, 1}, false)]
        public void NoTriplesTest(int[] numbers, bool expected)
        {
            bool actual = obj.NoTriples(numbers);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {1, 2, 7, 1}, true)]
        [TestCase(new int[] {1, 2, 8, 1}, false)]
        [TestCase(new int[] {2, 7, 1}, true)]
        public void Pattern51(int[] numbers, bool expected)
        {
            bool actual = obj.Pattern51(numbers);
            Assert.AreEqual(expected, actual);
        }
    }
}
