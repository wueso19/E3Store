using System;
using NUnit.Framework;
using SimplifyFraction;

namespace TestUnit
{
    [TestFixture]
    public class SimplifyFractionTests
    {
        [TestCase(4, 6, "2/3")]        
        [TestCase(10, 11, "10/11")]
        [TestCase(100, 400, "1/4")]
        [TestCase(4, 4, "1")]
        [TestCase(5, 1, "5")]
        public void TestSimplify(int numerator, int denominator, string expectedResult)
        {
            //Arrange
            Fraction fraction = new Fraction(numerator, denominator);

            //Act
            string simplifiedFraction = fraction.Simplify().ToString();

            //Assert
            Assert.AreEqual(expectedResult, simplifiedFraction);
        }

        [TestCase(5, 0)]
        public void TestSimplify_ThrowsDivideByZeroException(int numerator, int denominator)
        {
            //Arrange
            Fraction fraction = new Fraction(numerator, denominator);

            //Act
            Exception exception = Assert.Catch(() => fraction.Simplify());

            //Assert
            Assert.IsInstanceOf<DivideByZeroException>(exception);
        }
    }
}