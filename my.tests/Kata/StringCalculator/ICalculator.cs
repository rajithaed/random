namespace my.tests.Kata.StringCalculator
{
    public interface ICalculator  
    {
        decimal Sum(string strNumbers);
        Status Validate(string strNumbers);
    }
}