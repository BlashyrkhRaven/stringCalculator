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
                if (inputString.Contains(","))
                {
                    var stringNumbers = inputString.Split(',');
                    result = int.Parse(stringNumbers.First()) + int.Parse(stringNumbers.Last());
                }
                else
                {
                    result = int.Parse(inputString);
                }
            }
            return result;
        }
    }
}