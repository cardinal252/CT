namespace CodeTest.Services
{
    /// <summary>
    /// The calculator service
    /// Strictly, this class doesn't need an interface as its unlikely to be unplugged, but it makes for easier mocking for testing controllers etc
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
