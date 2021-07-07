using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics.CodeAnalysis;
using CodeTest.Services;

namespace CodeTest.Api.Controllers
{
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

        [Route("/get")]
        [HttpGet]
        public string Empty()
        {
            return "You must input a number in the form /get/x";
        }

        [Route("/get/{input}")]
        [HttpGet]
        public ActionResult Index(int input)
        {
            try
            {
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
