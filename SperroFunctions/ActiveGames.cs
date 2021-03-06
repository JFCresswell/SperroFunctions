using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using SperroFunctions.Models;
using System.Collections.Generic;
using Newtonsoft.Json;
using SperroFunctions.Interfaces;
using SperroFunctions.DependencyInjection.DependencyInjection;

namespace SperroFunctions
{
    public static class ActiveGames
    {
        [FunctionName("ActiveGames")]
        public static HttpResponseMessage Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "sperrov1/activegames")]HttpRequestMessage req,
            [Inject(typeof(IGameRepository))]IGameRepository gameRepository,
            TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            // Fetching the name from the path parameter in the request URL
            return req.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(gameRepository.FindActve()));
        }
    }
}
