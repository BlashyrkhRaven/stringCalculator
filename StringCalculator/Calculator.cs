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
            if (!string.IsNullOrEmpty(inputString))
            {
                var stringNumbers = inputString.Split(",\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                foreach (var stringNumber in stringNumbers)
                {
                    result += int.Parse(stringNumber);
                }
            }
            return result;
        }
    }
}