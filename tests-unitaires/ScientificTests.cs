using b3_dev_tu_flamant_benoit_armand_lelio;
using System;
using Xunit;

namespace tests_unitaires
{
    public class ScientificTests
    {
        [Fact]
        public void SquareTest()
        {
            //Tests for Square in Scientific class
            Assert.Equal(4, Arithmetic.Square(2));
            Assert.Equal(0.25, Arithmetic.Square(0.5));
            Assert.Equal(16, Arithmetic.Square(-4));
        }

        [Fact]
        public void SquareRootTest()
        {
            //Tests for SquareRoot in Scientific class
            Assert.Equal(2, Arithmetic.SquareRoot(4));
            Assert.Equal(0.5, Arithmetic.SquareRoot(0.25));
        }

        [Fact]
        public void PowerTest()
        {
            //Tests for Power in Scientific class
            Assert.Equal(16, Arithmetic.Power(2,4));
            Assert.Equal(0.125, Arithmetic.Power(0.5,3));
            Assert.Equal(-64, Arithmetic.Power(-4,3));
            Assert.Equal(25, Arithmetic.Power(-5,2));
            Assert.Equal(0.1, Arithmetic.Power(1,-1));
        }
    }
}
