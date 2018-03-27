using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace my.tests.Kata.PasswordVerifier
{
    public class PasswordHandler : IPasswordHandler
    {
        public PasswordStatus Verify(string password)
        {
            if (string.IsNullOrEmpty(password))
                return new PasswordStatus { Status = "invalid", Error = "null is not allowed!"};

          return new PasswordStatus();

        }

        public PasswordStatus CheckLength(string password)
        {
            var length = password.Length;
            if (length > 8) return new PasswordStatus { Status = "valid" };

            return new PasswordStatus
            {
                Status = "invalid",
                Error = "less than 8 chars"
            };
        }

        public PasswordStatus CheckUpperCase(string password)
        {
            var hasUppercase = password.Any(char.IsUpper);

            if (hasUppercase)
            {
                return new PasswordStatus() { Status = "valid"};
            }
            return new PasswordStatus(){Status = "invalid", Error = "no uppercase"};

        }

    }
}