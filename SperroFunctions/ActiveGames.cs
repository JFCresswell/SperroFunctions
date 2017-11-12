using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using SperroFunctions.Models;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SperroFunctions
{
    public static class ActiveGames
    {
        [FunctionName("ActiveGames")]
        public static HttpResponseMessage Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = "sperrov1/activegames")]HttpRequestMessage req, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            // TEMP: active games object
            var activeGames = new List<Game>();

            activeGames.Add(new Game()
            {
                Id = 1,
                Title = "Random Run",
                Description = "Total randomness",
                Publisher = new GamePublisher()
            });

            // Fetching the name from the path parameter in the request URL
            return req.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(activeGames));
        }
    }
}
