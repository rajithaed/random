namespace my.tests.Kata.PasswordVerifier
{
    public interface IPasswordHandler
    {
        PasswordStatus Verify(string password);
        PasswordStatus CheckLength(string password);
        PasswordStatus CheckUpperCase(string password);
    }

    public class PasswordStatus
    {
        public string Status { get; set; }
        public string Error { get; set; }
    }
}