namespace CodeTest.Services
{
    public class CalculatorResult
    {
        public CalculatorResult(string result)
        {
            Result = string.IsNullOrWhiteSpace(result) 
                ? string.Empty 
                : result;
        }

        public string Result { get; }
    }
}
