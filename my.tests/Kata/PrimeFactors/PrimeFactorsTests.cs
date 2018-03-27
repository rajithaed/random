using System;
using System.Text;
using Xunit;

namespace my.tests.Kata.PrimeFactors
{
    public class PrimeFactorsTests
    {
        private readonly IPrimeFactorCalc _primeFactorCalc;

        public PrimeFactorsTests()
        {
            _primeFactorCalc = new PrimeFactorCalc();
        }

        [Fact]
        public void Given2_WhenCalcPrimeFactors_Return2()
        {
            //Arrange
            int number = 2;

            //Act
            var result = _primeFactorCalc.GetFactors(number).ToArray();

            //Assert
            int[] expected = {2};
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Given3_WhenCalcPrimeFactors_Return3()
        {
            //Arrange
            int number = 3;

            //Act
            var result = _primeFactorCalc.GetFactors(number).ToArray();

            //Assert
            int[] expected = { 3 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Given4_WhenCalcPrimeFactors_Return22()
        {
            //Arrange
            int number = 4;

            //Act
            var result = _primeFactorCalc.GetFactors(number).ToArray();

            //Assert
            int[] expected = { 2,2 };
            Assert.Equal(expected, result);
        }
    }
}
