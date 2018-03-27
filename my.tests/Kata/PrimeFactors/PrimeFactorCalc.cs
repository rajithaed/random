using System.Collections.Generic;

namespace my.tests.Kata.PrimeFactors
{
    public class PrimeFactorCalc : IPrimeFactorCalc
    {
        private List<int> _primeNumbers;
        public PrimeFactorCalc()
        {
            _primeNumbers =  new List<int>() { 2, 3, 5, 7, 11 };

        }

        public List<int> GetFactors(int number)
        {

            var factors = new List<int>();

            foreach (var primeNumber in _primeNumbers)
            {
                var remainder = number % primeNumber;
                if (remainder == 0)
                {
                    factors.Add(number);
                }
            }

            return factors;
        }
    }
}