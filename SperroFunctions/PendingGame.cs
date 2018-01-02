using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using SperroFunctions.DependencyInjection.DependencyInjection;
using SperroFunctions.Interfaces;
using SperroFunctions.Models;

namespace SperroFunctions
{
    public static class PendingGame
    {
        [FunctionName("PendingGame")]
        public static HttpResponseMessage Run([HttpTrigger(AuthorizationLevel.Function,  "post", Route = "sperrov1/games/{pendinggame}")]HttpRequestMessage req,
            [Inject(typeof(IGameRepository))]IGameRepository gameRepository,
            Game pendinggame,
            TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            pendinggame.Status = GameApprovalStatus.Pending;

            gameRepository.Create(pendinggame);

            return req.CreateResponse(HttpStatusCode.OK);
        }
    }
}
