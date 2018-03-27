using Xunit;

namespace my.tests.Kata.PasswordVerifier
{
    public class PasswordVerifierTests
    {
        public PasswordVerifierTests()
        {
            _passwordHandler = new PasswordHandler();
        }

        private readonly IPasswordHandler _passwordHandler;

        [Fact]
        public void GivenPasswordLargerThan8Chars_WhenVerify_ReturnValid()
        {
            //Arrange
            var password = "123456789";

            //Act
            var result = _passwordHandler.CheckLength(password);

            //Assert
            Assert.Equal("valid", result.Status);
        }

        [Fact]
        public void GivenPasswordLessThan8Chars_WhenVerify_ReturnInvalid()
        {
            //Arrange
            var password = "12345";

            //Act
            var result = _passwordHandler.CheckLength(password);

            //Assert
            Assert.Equal("invalid", result.Status);
        }

        [Fact]
        public void GivenNullPassword_WhenVerify_ReturnInvalid()
        {
            //Arrange

            //Act
            var result = _passwordHandler.Verify(null);

            //Assert
            Assert.Equal("invalid", result.Status);
        }

        [Fact]
        public void GivenPassword_WhenVerify_ShouldHaveUpperCase()
        {
            //Arrange
            var password = "12345";

            //Act
            var result = _passwordHandler.CheckUpperCase(password);

            //Assert
            Assert.Equal("invalid", result.Status);
        }

        [Fact]
        public void GivenPasswordWithUpperCase_WhenVerify_ReturnValid()
        {
            //Arrange
            var password = "12U345";

            //Act
            var result = _passwordHandler.CheckUpperCase(password);

            //Assert
            Assert.Equal("valid", result.Status);
        }
    }
}