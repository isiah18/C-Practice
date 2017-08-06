using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using Warmups.BLL;

namespace WarmUps.Tests
{
    [TestFixture]
    public class StringTest
    {
        //Declare obj variable of type Strings
        private Strings obj;
        
        //Create instance of object.
        [SetUp]
        public void BeforeEachTest()
        {
            obj = new Strings();
        }

        //Say Hi Test
        [Test]
        [TestCase("Bob", "Hello Bob!")]
        [TestCase("Alice", "Hello Alice!")]
        [TestCase("X", "Hello X!")]
        public void SayHiTest(string name, string expected)
        {
            string actual = obj.SayHi(name); 
            Assert.AreEqual(expected, actual);
        }

        //Abba Test
        [Test]
        [TestCase("Hi", "Bye", "HiByeByeHi")]
        [TestCase("Yo", "Alice", "YoAliceAliceYo")]
        [TestCase("What", "Up", "WhatUpUpWhat")]
        public void AbbaTest(string a, string b, string expected)
        {
            string actual = obj.Abba(a, b);
            Assert.AreEqual(expected, actual);
        }

        //Make Tags Test
        [Test]
        [TestCase("i", "Yay", "<i>Yay</i>")]
        [TestCase("i", "Hello", "<i>Hello</i>")]
        [TestCase("cite", "Yay", "<cite>Yay</cite>")]
        public void MakeTagsTest(string a, string b, string expected)
        {
            string actual = obj.MakeTags(a, b);
            Assert.AreEqual(expected, actual);
        }

        //Insert Word Test
        [Test]
        [TestCase("<<>>", "Yay", "<<Yay>>")]
        [TestCase("<<>>", "WooHoo", "<<WooHoo>>")]
        [TestCase("[[]]", "word", "[[word]]")]
        public void InsertWordTest(string a, string b, string expected)
        {
            string actual = obj.InsertWord(a, b);
            Assert.AreEqual(expected, actual);
        }

        //Multiple Endings Test
        [Test]
        [TestCase("Hello", "lololo")]
        [TestCase("ab", "ababab")]
        [TestCase("Hi", "HiHiHi")]
        public void MultipleEndingsTest(string a, string expected)
        {
            string actual = obj.MultipleEndings(a);
            Assert.AreEqual(expected, actual);
        }

        //First Half Test
        [Test]
        [TestCase("WooHoo", "Woo")]
        [TestCase("HelloThere", "Hello")]
        [TestCase("abcdef", "abc")]
        public void FirstHalfTest(string a, string expected)
        {
            string actual = obj.FirstHalf(a);
            Assert.AreEqual(expected, actual);
        }

        //Trim One Test
        [Test]
        [TestCase("Hello", "ell")]
        [TestCase("java", "av")]
        [TestCase("coding", "odin")]
        public void TrimOneTest(string a, string expected)
        {
            string actual = obj.TrimOne(a);
            Assert.AreEqual(expected,actual);
        }

        //Long In Middle Test
        [Test]
        [TestCase("Hello", "hi", "hiHellohi")]
        [TestCase("hi", "Hello", "hiHellohi")]
        [TestCase("aaa", "b", "baaab")]
        public void LongInMiddleTest(string a, string b, string expected)
        {
            string actual = obj.LongInMiddle(a, b);
            Assert.AreEqual(expected, actual);
        }

        //Rotate Left 2 Test
        [Test]
        [TestCase("Hello", "lloHe")]
        [TestCase("java", "vaja")]
        [TestCase("Hi", "Hi")]
        public void RotateLeft2Test(string a, string expected)
        {
            string actual = obj.Rotateleft2(a);
            Assert.AreEqual(expected, actual);
        }

        //Rotate Right 2 Test
        [Test]
        [TestCase("Hello", "loHel")]
        [TestCase("java", "vaja")]
        [TestCase("Hi", "Hi")]
        public void RotateRight2Test(string a, string expected)
        {
            string actual = obj.RotateRight2(a);
            Assert.AreEqual(expected, actual);
        }

        //Take One Test
        [Test]
        [TestCase("Hello", true, "H")]
        [TestCase("Hello", false, "o")]
        [TestCase("oh", true, "o")]
        public void TakeOneTest(string a, bool b, string expected)
        {
            string actual = obj.TakeOne(a, b);
            Assert.AreEqual(expected,actual);
        }

        //Middle Two Test
        [Test]
        [TestCase("string", "ri")]
        [TestCase("code", "od")]
        [TestCase("Practice", "ct")]
        public void MiddleTwoTest(string a, string expected)
        {
            string actual = obj.MiddleTwo(a);
            Assert.AreEqual(expected, actual);
        }

        //Ends With Ly Test
        [Test]
        [TestCase("oddly", true)]
        [TestCase("y", false)]
        [TestCase("oddy", false)]
        public void EndsWithLYTest(string a, bool expected)
        {
            bool actual = obj.EndsWithLy(a);
            Assert.AreEqual(expected, actual);
        }

        //Front And Back Test
        [Test]
        [TestCase("Hello", 2, "Helo")]
        [TestCase("Chocolate", 3, "Choate")]
        [TestCase("Chocolate", 1, "Ce")]
        public void FrontAndBackTest(string a, int b, string expected)
        {
            string actual = obj.FrontAndBack(a,b);
            Assert.AreEqual(expected, actual);
        }

        //Take Two From Position Test
        [Test]
        [TestCase("java", 0, "ja")]
        [TestCase("java", 2, "va")]
        [TestCase("java", 3, "ja")]
        public void TakeTwoFromPositionTest(string a, int index, string expected)
        {
            string actual = obj.TakeTwoFromPosition(a, index);
            Assert.AreEqual(expected, actual);
        }

        //Has Bad Test
        [Test]
        [TestCase("badxx", true)]
        [TestCase("xbadxx", true)]
        [TestCase("xxbadxx", false)]
        [TestCase("b", false)]
        public void HasBadTest(string a, bool expected)
        {
            bool actual = obj.HasBad(a);
            Assert.AreEqual(expected, actual);
        }

        //At First Test
        [Test]
        [TestCase("hello", "he")]
        [TestCase("hi", "hi")]
        [TestCase("h", "h@")]
        public void AtFirstTest(string a, string expected)
        {
            string actual = obj.AtFirst(a);
            Assert.AreEqual(expected, actual);
        }

        //Last Chars Test
        [Test]
        [TestCase("last", "chars", "ls")]
        [TestCase("yo", "mama", "ya")]
        [TestCase("hi", "", "h@")]
        [TestCase("", "", "@@")]
        public void LastCharsTest(string a, string b, string expected)
        {
            string actual = obj.LastChars(a, b);
            Assert.AreEqual(expected, actual);
        }

        //ConCat Test
        [Test]
        [TestCase("abc", "cat", "abcat")]
        [TestCase("dog", "cat", "dogcat")]
        [TestCase("abc", "", "abc")]
        public void ConCatTest(string a, string b, string expected)
        {
            string actual = obj.ConCat(a, b);
            Assert.AreEqual(expected, actual);
        }

        //Swap Last Test
        [Test]
        [TestCase("coding", "codign")]
        [TestCase("cat", "cta")]
        [TestCase("ab", "ba")]
        public void SwapLastTest(string a, string expected)
        {
            string actual = obj.SwapLast(a);
            Assert.AreEqual(expected, actual);
        }

        //Front Again Test
        [Test]
        [TestCase("edited", true)]
        [TestCase("edit", false)]
        [TestCase("ed", true)]
        public void FrontAgainTest(string a, bool expected)
        {
            bool actual = obj.FrontAgain(a);
            Assert.AreEqual(expected, actual);
        }

        //MinCat Test
        [Test]
        [TestCase("Hello", "Hi", "loHi")]
        [TestCase("Hello", "java", "ellojava")]
        [TestCase("java", "Hello", "javaello")]
        [TestCase("", "Hello", "")]
        public void MinCatTest(string a, string b, string expected)
        {
            string actual = obj.MinCat(a, b);
            Assert.AreEqual(expected, actual);
        }

        //Tweak Front Test
        [Test]
        [TestCase("Hello", "llo")]
        [TestCase("away", "aay")]
        [TestCase("abed", "abed")]
        public void TweakFrontTest(string a, string expected)
        {
            string actual = obj.TweakFront(a);
            Assert.AreEqual(expected, actual);
        }

        //Strip X Test
        [Test]
        [TestCase("xHix", "Hi")]
        [TestCase("xHi", "Hi")]
        [TestCase("Hxix", "Hxi")]
        public void StripXTest(string a, string expected)
        {
            string actual = obj.StripX(a);
            Assert.AreEqual(expected, actual);
        }

    }
}

