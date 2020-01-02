using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace IECaching
{
    public static class WhatTimeFunction
    {
        [FunctionName("GetWhatTime")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            //TODO: Uncomment next line to fix the problem
            //req.HttpContext.Response.Headers.Add("Cache-Control", "no-cache");
            
            return new OkObjectResult(new { Time = DateTime.Now });
        }
    }
}
