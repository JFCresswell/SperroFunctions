using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using SperroFunctions.Models;
using SperroFunctions.DependencyInjection.DependencyInjection;
using SperroFunctions.Interfaces;
using Newtonsoft.Json;

namespace SperroFunctions
{
    public static class Games
    {
        [FunctionName("Games")]
        public static HttpResponseMessage Run([
            HttpTrigger(AuthorizationLevel.Function, "get", Route = "sperrov1/game/{id}")]HttpRequestMessage req,
            [Inject(typeof(IGameRepository))]IGameRepository gameRepository,
            int id,
            TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            // Fetching the name from the path parameter in the request URL
            return req.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(gameRepository.GetById(id)));
 
        }
    }
}
