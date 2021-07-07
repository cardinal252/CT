namespace CodeTest.Services
{
    /// <summary>
    /// Result class to aid immutability and prevent null checking concerns
    /// </summary>
    public class CalculatorResult
    {
        /// <summary>
        /// The empty calculator result
        /// </summary>
        public static CalculatorResult Empty => new CalculatorResult(string.Empty);

        public CalculatorResult(string result)
        {
            Result = string.IsNullOrWhiteSpace(result) 
                ? string.Empty 
                : result;
        }

        /// <summary>
        /// The result
        /// </summary>
        public string Result { get; }

        /// <summary>
        /// Checks to see if the calculator result
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public bool IsEmpty(CalculatorResult result)
        {
            return result == Empty || result?.Result == string.Empty;
        }
    }
}
