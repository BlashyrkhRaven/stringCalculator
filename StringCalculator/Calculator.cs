using System;
using System.Linq;

namespace StringCalculator
{
    internal class Calculator
    {
        public Calculator()
        {
        }

        internal int Add(string inputString)
        {
            var result = 0;
            var separator = ",\n";
            if (!string.IsNullOrEmpty(inputString))
            {
                if (inputString.StartsWith("//"))
                {
                    var firstRow = inputString.Split("\n".ToCharArray()).First();
                    separator = firstRow.Substring(2);
                    inputString = inputString.Substring(firstRow.Length);
                }
                var stringNumbers = inputString.Split(separator.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                foreach (var stringNumber in stringNumbers)
                {
                    result += int.Parse(stringNumber);
                }
            }
            return result;
        }
    }
}