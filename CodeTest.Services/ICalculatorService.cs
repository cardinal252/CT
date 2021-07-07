namespace CodeTest.Services
{
    /// <summary>
    /// The calculator service
    /// </summary>
    public interface ICalculatorService
    {
        /// <summary>
        /// Calculates the output based on the input
        /// </summary>
        /// <param name="input">The input</param>
        /// <returns>The output</returns>
        CalculatorResult Calculate(int input);
    }
}
