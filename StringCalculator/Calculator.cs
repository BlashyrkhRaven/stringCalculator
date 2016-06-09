using System;
using System.Linq;
using System.Text;

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
            var negativeNumbers = new StringBuilder();

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
                    var partial = int.Parse(stringNumber);
                    if (partial < 0)
                    {
                        negativeNumbers.Append(stringNumber).Append(',');
                    }
                    else if(partial <= 1000)
                    {
                        result += partial;
                    }
                }

            }
            if (negativeNumbers.Length > 0)
            {
                throw new ArgumentException(string.Concat("Negatives not allowed: ", negativeNumbers.ToString().TrimEnd(',')));
            }
            return result;
        }
    }
}