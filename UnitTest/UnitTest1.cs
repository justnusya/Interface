using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System;
using System.Numerics;
using UnitTest;
using Interface;
namespace UnitTest
{
    [TestClass]
    public class MyFracTests
    {
        [TestMethod]
        public void ApplyingNumbersToMyFrac()
        {
            MyFrac num = new MyFrac(1, 3);
            Assert.AreEqual(1, num.nom);
            Assert.AreEqual(3, num.denom);
        }
        [TestMethod]
        public void TestingStringConstructor()
        {
            MyFrac num = new MyFrac("2/7");
            Assert.AreEqual(2, num.nom);
            Assert.AreEqual(7, num.denom);
        }
        [TestMethod]
        public void AddingNums()
        {
            MyFrac num = new MyFrac(1, 7);
            MyFrac num2 = new MyFrac(3, 7);
            MyFrac res = num.Add(num2);
            Assert.AreEqual(4, res.nom);
            Assert.AreEqual(7, res.denom);
        } 
    }
    [TestClass]
    public class MyComplexTests
    {
        [TestMethod]
        public void ApplyingNumbersToComplex()
        {
            MyComplex num = new MyComplex(2,36);
            Assert.AreEqual(2, num.re);
            Assert.AreEqual(36, num.im);
        }
    }
}
