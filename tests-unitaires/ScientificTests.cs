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
            Assert.Equal(4, Scientific.Square(2));
            Assert.Equal(0.25, Scientific.Square(0.5));
            Assert.Equal(16, Scientific.Square(-4));
        }

        [Fact]
        public void SquareRootTest()
        {
            //Tests for SquareRoot in Scientific class
            Assert.Equal(2, Scientific.SquareRoot(4));
            Assert.Equal(0.5, Scientific.SquareRoot(0.25));
        }

        [Fact]
        public void PowerTest()
        {
            //Tests for Power in Scientific class
            Assert.Equal(16, Scientific.Power(2, 4));
            Assert.Equal(0.125, Scientific.Power(0.5, 3));
            Assert.Equal(-64, Scientific.Power(-4, 3));
            Assert.Equal(25, Scientific.Power(-5, 2));
            Assert.Equal(0.1, Scientific.Power(10, -1));
        }
    }
}
