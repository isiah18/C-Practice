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
    class ConditionalsTest
    {
        Conditionals obj;

        [SetUp]
        public void BeforeEachTest()
        {
            obj = new Conditionals();
        }

        //Are We In Trouble Test
        [TestCase(true, true, true)]
        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        public void AreWeInTroubleTest(bool a, bool b, bool expected)
        {
            bool actual = obj.AreWeInTrouble(a, b);
            Assert.AreEqual(expected, actual);
        }

        //Can Sleep In Test
        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        [TestCase(false, true, true)]
        public void CanSleepInTest(bool a, bool b, bool expected)
        {
            bool actual = obj.CanSleepIn(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 3)]
        [TestCase(3, 2, 5)]
        [TestCase(2, 2, 8)]
        public void SumDoubleTest(int a, int b, int expected)
        {
            int actual = obj.SumDouble(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(23, 4)]
        [TestCase(10, 11)]
        [TestCase(21, 0)]
        public void Diff21Test(int a, int expected)
        {
            int actual = obj.Diff21(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(true, 6, true)]
        [TestCase(true, 7, false)]
        [TestCase(false, 6, false)]
        public void ParrotTroubleTest(bool isTalking, int hour, bool expected)
        {
            bool actual = obj.ParrotTrouble(isTalking, hour);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(9, 10, true)]
        [TestCase(9, 9, false)]
        [TestCase(1, 9, true)]
        public void Makes10Test(int a, int b, bool expected)
        {
            bool actual = obj.Makes10(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(103, true)]
        [TestCase(90, true)]
        [TestCase(89, false)]
        public void NearHundredTest(int n, bool expected)
        {
            bool actual = obj.NearHundred(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, -1, false, true)]
        [TestCase(-1, 1, false, true)]
        [TestCase(-4, -5, true, true)]
        public void PosNegTest(int a, int b, bool isNegative, bool expected)
        {
            bool actual = obj.PosNeg(a, b, isNegative);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("candy", "not candy")]
        [TestCase("x", "not x")]
        [TestCase("not bad", "not bad")]
        public void NotStringTest(string s, string expected)
        {
            string actual = obj.NotString(s);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("kitten", 1, "ktten")]
        [TestCase("kitten", 0, "itten")]
        [TestCase("kitten", 4, "kittn")]
        public void MissingCharTest(string s, int n, string expected)
        {
            string actual = obj.MissingChar(s, n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("code", "eodc")]
        [TestCase("a", "a")]
        [TestCase("ab", "ba")]
        public void FrontBackTest(string s, string expected)
        {
            string actual = obj.FrontBack(s);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Microsoft", "MicMicMic")]
        [TestCase("Chocolate", "ChoChoCho")]
        [TestCase("at", "atatat")]
        public void Front3Test(string s, string expected)
        {
            string actual = obj.Front3(s);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("cat", "tcatt")]
        [TestCase("Hello", "oHelloo")]
        [TestCase("a", "aaa")]
        public void BackAroundTest(string s, string expected)
        {
            string actual = obj.BackAround(s);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, true)]
        [TestCase(10, true)]
        [TestCase(8, false)]
        public void Multiple3or5Test(int a, bool expected)
        {
            bool actual = obj.Multiple3or5(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("hi there", true)]
        [TestCase("hi", true)]
        [TestCase("high up", false)]
        public void StartHiTest(string s, bool expected)
        {
            bool actual = obj.StartHi(s);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(120, -1, true)]
        [TestCase(-1, 120, true)]
        [TestCase(2, 120, false)]
        public void IcyHotTest(int temp1, int temp2, bool expected)
        {
            bool actual = obj.IcyHot(temp1, temp2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(12, 99, true)]
        [TestCase(21, 12, true)]
        [TestCase(8, 99, false)]
        public void Between10And20Test(int a, int b, bool expected)
        {
            bool actual = obj.Between10and20(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(13, 20, 10, true)]
        [TestCase(20, 19, 10, true)]
        [TestCase(20, 10, 12, false)]
        public void HasTeenTest(int a, int b, int c, bool expected)
        {
            bool actual = obj.HasTeen(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(13, 99, true)]
        [TestCase(21, 19, true)]
        [TestCase(13, 13, false)]
        public void SoAloneTest(int a, int b, bool expected)
        {
            bool actual = obj.SoAlone(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("adelbc", "abc")]
        [TestCase("adelHello", "aHello")]
        [TestCase("adedbc", "adedbc")]
        public void RemoveDelTest(string s, string expected)
        {
            string actual = obj.RemoveDel(s);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("mix snacks", true)]
        [TestCase("pix snacks", true)]
        [TestCase("piz snacks", false)]
        public void IxStartTest(string s, bool expected)
        {
            bool actual = obj.IxStart(s);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("ozymandias", "oz")]
        [TestCase("bzoo", "z")]
        [TestCase("oxx", "o")]
        public void StartOzTest(string s, string expected)
        {
            string actual = obj.StartOz(s);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 3, 3)]
        [TestCase(1, 3, 2, 3)]
        [TestCase(3, 2, 1, 3)]
        public void MaxTest(int a, int b, int c, int expected)
        {
            int actual = obj.Max(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(8, 13, 8)]
        [TestCase(13, 8, 8)]
        [TestCase(13, 7, 0)]
        public void CloserTest(int a, int b, int expected)
        {
            int actual = obj.Closer(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Hello", true)]
        [TestCase("Heelle", true)]
        [TestCase("Heelele", false)]
        public void GotETest(string s, bool expected)
        {
            bool actual = obj.GotE(s);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Hello", "HeLLO")]
        [TestCase("hi there", "hi thERE")]
        [TestCase("hi", "HI")]
        public void EndUpTest(string s, string expected)
        {
            string actual = obj.EndUp(s);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Miracle", 2, "Mrce")]
        [TestCase("abcdefg", 2, "aceg")]
        [TestCase("abcdefg", 3, "adg")]
        public void EveryNthTest(string s, int n, string expected)
        {
            string actual = obj.EveryNth(s, n);
            Assert.AreEqual(expected, actual);
        }

    }
}
