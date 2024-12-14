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
            Assert.Equals(1, num.nom);
            Assert.Equals(3, num.denom);
        }
        [TestMethod]
        public void TestingStringConstructor()
        {
            MyFrac num = new MyFrac("2/7");
            Assert.Equals(2, num.nom);
            Assert.Equals(7, num.denom);
        }
        [TestMethod]
        public void AddingNums()
        {
            MyFrac num = new MyFrac(1, 7);
            MyFrac num2 = new MyFrac(3, 7);
            Assert.Equals(new MyFrac(4, 7), num.Add(num2));
        } 
    }
    [TestClass]
    public class MyComplexTests
    {
        [TestMethod]
        public void ApplyingNumbersToComplex()
        {
            MyComplex num = new MyComplex(2,36);
            Assert.Equals(2, num.re);
            Assert.Equals(36, num.im);
        }
    }
}
