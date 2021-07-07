using FluentAssertions;
using NUnit.Framework;

namespace CodeTest.Services.Tests
{
    /// <summary>
    /// The calculator service tests
    /// </summary>
    public class CalculatorServiceTests
    {
        // I chose nunit for ease of use and tooling availability, could use any though
        // for this test, there is no external integration, but if there were I would use the repository pattern
        // which would allow for better mocking

        private ICalculatorService service;

        /// <summary>
        /// Runs before every test
        /// </summary>
        [SetUp]
        public void Setup()
        {
            service = new CalculatorService();
        }

        /// <summary>
        /// Tests getting a value that is strictly a multiple of 7
        /// </summary>
        [Test]
        public void Calculate_MultipleOf7Only()
        {
            // Arrange
            const string expected = "E";

            // Act
            CalculatorResult calculatorResult = service.Calculate(14);

            // Assert
            calculatorResult.Result.Should().Be(expected);
        }

        /// <summary>
        /// Tests getting a value that is strictly a multiple of 9 
        /// </summary>
        [Test]
        public void Calculate_MultipleOf9Only()
        {
            // Arrange
            const string expected = "E";

            // Act
            CalculatorResult calculatorResult = service.Calculate(14);

            // Assert
            calculatorResult.Result.Should().Be(expected);
        }

        /// <summary>
        /// Tests getting a value that is a multiple of 7 or 9
        /// </summary>
        [Test]
        public void Calculate_MultipleOf7And9()
        {
            // Arrange
            const string expected = "EG";

            // Act
            CalculatorResult calculatorResult = service.Calculate(63);

            // Assert
            calculatorResult.Result.Should().Be(expected);
        }

        /// <summary>
        /// Tests getting a value that is a multiple of neither 
        /// </summary>
        [Test]
        public void Calculate_MultipleOfNeither()
        {
            // Arrange
            const string expected = "5";

            // Act
            CalculatorResult calculatorResult = service.Calculate(5);

            // Assert
            calculatorResult.Result.Should().Be(expected);
        }

        /// <summary>
        /// Tests getting a value with an input of zero
        /// </summary>
        [Test]
        public void Calculate_Zero()
        {
            // Arrange
            const string expected = "0";

            // Act
            CalculatorResult calculatorResult = service.Calculate(0);

            // Assert
            calculatorResult.Result.Should().Be(expected);
        }

        /// <summary>
        /// Tests getting a value with an input of a negative
        /// </summary>
        [Test]
        public void Calculate_Negative()
        {
            // Arrange
            const string expected = "E";

            // Act
            CalculatorResult calculatorResult = service.Calculate(-14);

            // Assert
            calculatorResult.Result.Should().Be(expected);
        }
    }
}