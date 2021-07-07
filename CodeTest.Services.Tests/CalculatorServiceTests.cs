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
        public void Test1()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}