using FluentAssertions;
using NUnit.Framework;

namespace CodeTest.Services.Tests
{
    public class Tests
    {
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
        /// Tests getting 
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
        /// Tests getting 
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
        /// Tests getting 
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
        /// Tests getting 
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
    }
}