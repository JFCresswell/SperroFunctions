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
            HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = "sperrov1/games/game")]HttpRequestMessage req,
            [Inject(typeof(IGameRepository))]IGameRepository gameRepository,
            TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            if (req.Method == HttpMethod.Get)
            {
                int id = int.Parse(req.GetQueryNameValuePairs().FirstOrDefault(q => string.Compare(q.Key, "id", true) == 0).Value);

                // Fetching the name from the path parameter in the request URL
                return req.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(gameRepository.GetById(id)));
            }
            else if (req.Method == HttpMethod.Post)
            {
                return req.CreateResponse(HttpStatusCode.OK, "Post called, not yet implemented");
            }

            return req.CreateResponse(HttpStatusCode.NotImplemented);

        }
    }
}
