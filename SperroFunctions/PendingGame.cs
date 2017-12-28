using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace SperroFunctions
{
    public static class PendingGame
    {
        [FunctionName("PendingGame")]
        public static HttpResponseMessage Run([HttpTrigger(AuthorizationLevel.Function,  "post", Route = "sperrov1/games/pendinggame")]HttpRequestMessage req, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            // Fetching the name from the path parameter in the request URL
            return req.CreateResponse(HttpStatusCode.OK, "Hello from pending game");
        }
    }
}
