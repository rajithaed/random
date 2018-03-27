using System.Collections.Generic;

namespace my.tests.Kata.PrimeFactors
{
    public interface IPrimeFactorCalc
    {
        List<int> GetFactors(int number);
    }
}