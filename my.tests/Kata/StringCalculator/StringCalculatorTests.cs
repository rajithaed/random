using Xunit;

namespace my.tests.Kata.StringCalculator
{
    public class StringCalculatorTests
    {
        private readonly ICalculator _calculator;

        public StringCalculatorTests()
        {
            _calculator = new StringCalculator();
        }

        [Fact]
        public void Given0_WhenCalcSum_ThenReturn0()
        {
            //Arrange
            var strNumbers = "0";

            //Act
           var result = _calculator.Sum(strNumbers);

            //Assert
            Assert.Equal(0, result);
        }
        [Fact]
        public void GivenEmptyStr_WhenCalcSum_ThenReturn0()
        {
            //Arrange
            var strNumbers = "";

            //Act
            var result = _calculator.Sum(strNumbers);

            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Given1_WhenCalcSum_ThenReturn1()
        {
            //Arrange
            var strNumbers = "1";

            //Act
            var result = _calculator.Sum(strNumbers);

            //Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Given12_WhenCalcSum_ThenReturn3()
        {
            //Arrange
            var strNumbers = "1,2";

            //Act
            var result = _calculator.Sum(strNumbers);

            //Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Given123_WhenCalcSum_ThenReturnUnknownLength()
        {
            //Arrange
            var strNumbers = "1,2,";

            //Act
            var result = _calculator.Validate(strNumbers);

            //Assert
            Assert.Equal(Status.UnknownLength, result);
        }

        //1\n2,3
        [Fact]
        public void GivenValidNewLine_WhenCalcSum_ThenReturnCorrectSum()
        {
            //Arrange
            var strNumbers = "1\\n2";

            //Act
            var result = _calculator.Sum(strNumbers);

            //Assert
            Assert.Equal(3, result);
        }
    }
}
