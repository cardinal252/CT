using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using CodeTest.Services;

namespace CodeTest.Api.Controllers
{
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
        public string Index(int input)
        {
            try
            {
                return calculatorService.Calculate(input);
            }
            catch (Exception ex)
            {
                // todo: figure out something better to do with this
                // hand off for logging
                logger.LogError(ex, "An error occurred");
                throw;
            }
        }
    }
}
