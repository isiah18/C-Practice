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
    class ArrayTest
    { 
    
        Arrays obj;

        [SetUp]
        public void BeforeEachTest()
        {
            obj = new Arrays();
        }

        //First Last 6 Test
        [TestCase(new int[] {1, 2, 6}, true)]
        [TestCase(new int[] {6, 1, 2, 3}, true)]
        [TestCase(new int[] {13, 6, 1, 2, 3}, false)]
        public void FirstLast6Test(int[] intArray, bool expected)
        {
            bool actual = obj.FirstLast6(intArray);
            Assert.AreEqual(expected, actual);
        }

        //Same First Last Test
        [TestCase(new int[] {1, 2, 3}, false)]
        [TestCase(new int[] {1, 2, 3, 1}, true)]
        [TestCase(new int[] {1, 2, 1}, true)]
        public void SameFirstLastTest(int[] intArray, bool expected)
        {
            bool actual = obj.SameFirstLast(intArray);
            Assert.AreEqual(expected, actual);
        }

        //Make PI Test
        [TestCase(3, new int[] { 3, 1, 4 })]
        [TestCase(5, new int[] { 3, 1, 4, 1, 5 })]
        [TestCase(7, new int[] { 3, 1, 4, 1, 5, 9, 2 })]
        public void MakePITest(int n, int[] expected)
        {
            int[] actual = obj.MakePi(n);
            Assert.AreEqual(expected, actual);
        }

        //Common End Test
        [TestCase(new int[] {1, 2, 3}, new int[] {7, 3}, true)]
        [TestCase(new int[] {1, 2, 3}, new int[] {7, 3, 2}, false)]
        [TestCase(new int[] {1, 2, 3}, new int[] {1, 3}, true)]
        public void CommonEndTest(int[] arrayA, int[] arrayB, bool expected)
        {
            bool actual = obj.commonEnd(arrayA, arrayB);
            Assert.AreEqual(expected, actual);
        }

        //Sum Test
        [TestCase(new int[] {1, 2, 3}, 6)]
        [TestCase(new int[] {5, 11, 2}, 18)]
        [TestCase(new int[] {7, 0, 0}, 7)]
        public void SumTest(int[] intArray, int expected)
        {
            int actual = obj.Sum(intArray);
            Assert.AreEqual(expected, actual);
        }
        
        //Rotate Left Test
        [TestCase(new int[] {1, 2, 3}, new int[] {2, 3, 1})]
        [TestCase(new int[] {5, 11, 9}, new int[] {11, 9, 5})]
        [TestCase(new int[] {7, 0, 0}, new int[] {0, 0, 7})]
        public void RotateLeftTest(int[] arrayA, int[] expected)
        {
            int[] actual = obj.RotateLeft(arrayA);
            Assert.AreEqual(expected, actual);
        }

        //Reverse Test
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]
        [TestCase(new int[] { 5, 11, 9 }, new int[] { 9, 11, 5 })]
        [TestCase(new int[] { 7, 0, 0 }, new int[] { 0, 0, 7 })]
        public void ReverseTest(int[] arrayA, int[] expected)
        {
            int[] actual = obj.Reverse(arrayA);
            Assert.AreEqual(expected, actual);
        }

        //Higher Wins Test
        [TestCase(new int[] {1, 2, 3}, new int[] {3, 3, 3})]
        [TestCase(new int[] {11, 5, 9}, new int[] {11, 11, 11})]
        [TestCase(new int[] {2, 11, 3}, new int[] {3, 3, 3})]
        public void HigherWinsTest(int[] arrayA, int[] expected)
        {
            int[] actual = obj.HigherWins(arrayA);
            Assert.AreEqual(expected, actual);
        }

        //Get Middle Test
        [TestCase(new int[] {1, 2, 3}, new int[] {4, 5, 6}, new int[] {2, 5})]
        [TestCase(new int[] {7, 7, 7}, new int[] {3, 8, 0}, new int[] {7, 8})]
        [TestCase(new int[] {5, 2, 9}, new int[] {1, 4, 5}, new int[] {2, 4})]
        public void GetMiddleTest(int[] arrayA, int[] arrayB, int[] expected)
        {
            int[] actual = obj.GetMiddle(arrayA, arrayB);
            Assert.AreEqual(expected, actual);
        }

        //Has Even Test
        [TestCase(new int[] {2, 5}, true)]
        [TestCase(new int[] {4, 3}, true)]
        [TestCase(new int[] {7, 5}, false)]
        public void HasEven(int[] arrayA, bool expected)
        {
            bool actual = obj.HasEven(arrayA);
            Assert.AreEqual(expected, actual);
        }

        //Keep Last Test
        [TestCase(new int[] {4, 5, 6}, new int[] {0, 0, 0, 0, 0, 6})]
        [TestCase(new int[] {1, 2}, new int[] {0, 0, 0, 2})]
        [TestCase(new int[] {3}, new int[] {0, 3})]
        public void KeepLastTest(int[] arrayA, int[] expected)
        {
            int[] actual = obj.KeepLast(arrayA);
            Assert.AreEqual(expected, actual);
        }

        //Double23 Test
        [TestCase(new int[] {2, 2, 3}, true)]
        [TestCase(new int[] {3, 4, 5, 3}, true)]
        [TestCase(new int[] {2, 3, 2, 2}, false)]
        public void Double23Test(int[] arrayA, bool expected)
        {
            bool actual = obj.Double23(arrayA);
            Assert.AreEqual(expected, actual);
        }

        //Fix 23 Test
        [TestCase(new int[] {1, 2, 3}, new int[] {1, 2, 0})]
        [TestCase(new int[] {2, 3, 5}, new int[] {2, 0, 5})]
        [TestCase(new int[] {1, 2, 1}, new int[] {1, 2, 1})]
        public void Fix23Test(int[] arrayA, int[] expected)
        {
            int[] actual = obj.Fix23(arrayA);
            Assert.AreEqual(expected, actual);
        }

        //Unlucky 1 Test
        [TestCase(new int[] {1, 3, 4, 5}, true)]
        [TestCase(new int[] {2, 1, 3, 4, 5}, true)]
        [TestCase(new int[] {1, 1, 1}, false)]
        public void Unlucky1Test(int[] arrayA, bool expected)
        {
            bool actual = obj.Unlucky1(arrayA);
            Assert.AreEqual(expected, actual);
        }

        //Make Two Test
        [TestCase(new int[] {4, 5}, new int[] {1, 2, 3}, new int[] {4, 5})]
        [TestCase(new int[] {4}, new int[] {1, 2, 3}, new int[] {4, 1})]
        [TestCase(new int[] {}, new int[] {1, 2}, new int[] {1, 2})]
        public void MakeTwoTest(int[] arrayA, int[] arrayB, int[] expected)
        {
            int[] actual = obj.make2(arrayA, arrayB);
            Assert.AreEqual(expected, actual);
        }



    }
}
