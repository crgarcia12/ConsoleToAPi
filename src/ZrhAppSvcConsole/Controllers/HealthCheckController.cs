﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZrhAppSvcConsoleWeb.Controllers
{
    [ApiController]
    [Route("")]
    public class HealthCheckController : ControllerBase
    {
        private readonly ILogger<HealthCheckController> _logger;

        public HealthCheckController(ILogger<HealthCheckController> logger)
        {
            _logger = logger;

        }
        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation("health check Ok!");
            return Ok("Healthy!");
        }
    }
}
