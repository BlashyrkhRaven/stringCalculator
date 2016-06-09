using System;

namespace StringCalculator
{
    internal class Calculator
    {
        public Calculator()
        {
        }

        internal int Add(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))   return 0;
            return int.Parse(inputString);
        }
    }
}