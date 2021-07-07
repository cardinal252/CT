using System;

namespace CodeTest.Services
{
    /// <summary>
    /// Responsible for calculating output
    /// </summary>
    public class CalculatorService : ICalculatorService
    {
        /// <summary>
        /// Calculates an output for a given input
        /// </summary>
        /// <param name="input">The input</param>
        /// <returns>The output</returns>
        public string Calculate(int input)
        {
            bool divisibleBy9 = input % 9 == 0;
            bool divisibleBy7 = input % 7 == 0;
            if (divisibleBy7 && divisibleBy9)
            {
                return "EG";
            }

            if (divisibleBy7)
            {
                return "E";
            }

            if (divisibleBy9)
            {
                return "G";
            }

            return input.ToString();

        }
    }
}
