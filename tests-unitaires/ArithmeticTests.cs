using b3_dev_tu_flamant_benoit_armand_lelio;
using System;
using Xunit;

namespace tests_unitaires
{
    public class ArithmeticTests
    {
        [Fact]
        public void AdditionTest()
        {
            //Tests for Addition in Arithmetic class
            Assert.Equal(7, Arithmetic.Addition(4, 3));
            Assert.Equal(-1, Arithmetic.Addition(-4, 3));
            Assert.Equal(-4.9, Arithmetic.Addition(3.4, -8.3));
        }

        [Fact]
        public void SubstractionTest()
        {
            //Tests for Substraction in Arithmetic class
            Assert.Equal(1, Arithmetic.Substraction(4, 3));
            Assert.Equal(-7, Arithmetic.Substraction(-4, 3));
            Assert.Equal(-11.3, Arithmetic.Substraction(-3, 8.3));
        }

        [Fact]
        public void MultiplicationTest()
        {
            //Tests for Multiplication in Arithmetic class
            Assert.Equal(12, Arithmetic.Multiplication(4, 3));
            Assert.Equal(-12, Arithmetic.Multiplication(-4, 3));
            Assert.Equal(41.5, Arithmetic.Multiplication(-5, -8.3));
        }

        [Fact]
        public void DivisionTest()
        {
            //Tests for Division in Arithmetic class
            Assert.Equal(2, Arithmetic.Division(4, 2));
            Assert.Equal(-2, Arithmetic.Division(-4, 2));
            Assert.Equal(-0.5, Arithmetic.Division(1, -2));
            Assert.Equal(4, Arithmetic.Division(2, 0.5));
        }

        [Fact]
        public void PercentageTest()
        {
            //Tests for Percentage in Arithmetic class
            Assert.Equal(51, Arithmetic.Percentage(100, 51));
            Assert.Equal(10, Arithmetic.Percentage(50, 20));
            Assert.Equal(32.99, Arithmetic.Percentage(65.98, 50));
        }
    }
}
