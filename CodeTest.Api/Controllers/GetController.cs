// there should be a copyright notice on all files enterprise

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics.CodeAnalysis;
using CodeTest.Services;

namespace CodeTest.Api.Controllers
{
    /// <summary>
    /// The main controller class to allow work to happen
    /// Rate limiting and security is assumed to be handled by an api manager, else it needs to happen here 
    /// </summary>
    [ExcludeFromCodeCoverage] // Whilst this is unit testable, it only acts as a wrapper to hand off to the service
    [ApiController]
    public sealed class GetController : ControllerBase
    {
        private readonly ILogger<GetController> logger;
        private readonly ICalculatorService calculatorService;

        public GetController(ILogger<GetController> logger, ICalculatorService calculatorService)
        {
            this.logger = logger;
            this.calculatorService = calculatorService;
        }

        /// <summary>
        /// Provides a helpful status to aid usage
        /// </summary>
        /// <returns>
        /// Instructions on how to use properly - could be done better with a formal standard such as swagger, but not the time
        /// </returns>
        [Route("/get")]
        [HttpGet]
        public string Empty()
        {
            return "You must input a number in the form /get/x";
        }

        /// <summary>
        /// This is where the fun begins
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [Route("/get/{input}")]
        [HttpGet]
        public ActionResult Index(int input)
        {
            // for other input types, I would expect to do basic validations here - they would warrant unit tests to be written
            // status codes should be given appropriate to the data etc
            try
            {
                // Ensure there is a 200 status code 
                return Ok(calculatorService.Calculate(input));
            }
            catch (Exception ex)
            {
                // hand off for logging
                logger.LogError(ex, "An error occurred");
                return StatusCode(500);
            }
        }
    }
}
