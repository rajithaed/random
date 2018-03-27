using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace my.tests.Kata.StringCalculator
{
    public class StringCalculator : ICalculator
    {
        public decimal Sum(string strNumbers)
        {
            if (string.IsNullOrEmpty(strNumbers)) return 0;
            return CalcSum(strNumbers);
        }

        public Status Validate(string strNumbers)
        {
            var hasNewLine = strNumbers.Contains("\\n");
            if (hasNewLine)
            {
                var replacementStr = Regex.Replace(strNumbers, @"\t|\\n|\r", ",");
                var list = replacementStr.Split(",").ToList();

                return GetStatus(list);
            }

            var strList = strNumbers.Split(",").ToList();
            return GetStatus(strList);
        }

        private Status GetStatus(List<string> strList)
        {
            if (strList.Count <= 2)
                return Status.Valid;
            return Status.UnknownLength;
        }

        private int CalcSum(string strNumbers)
        {
            if (Validate(strNumbers) == Status.Valid)
            {
                var numbersList = GetNumbersFromString(strNumbers);
                var enumerable = numbersList as int[] ?? numbersList.ToArray();
                var sum = enumerable.Sum();
                return sum;
            }

            return 0;
        }

        private IEnumerable<int> GetNumbersFromString(string strNumbers)
        {
            var numberList = new List<int>();
            List<string> strList;

            var hasNewLine = strNumbers.Contains("\\n");
            if (hasNewLine)
            {
                var replacementStr = Regex.Replace(strNumbers, @"\t|\\n|\r", ",");
                strList = replacementStr.Split(",").ToList();
            }
            else
            {
                strList = strNumbers.Split(",").ToList();
            }


            foreach (var val in strList)
            {
                var valInt = int.Parse(val);
                numberList.Add(valInt);
            }

            return numberList;
        }
    }
}