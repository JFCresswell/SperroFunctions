using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;
using SperroFunctions.DependencyInjection.DependencyInjection;
using SperroFunctions.Interfaces;
using SperroFunctions.Models;

namespace SperroFunctions
{
    public static class PendingGame
    {
        [FunctionName("PendingGame")]
        public static HttpResponseMessage Run([HttpTrigger(AuthorizationLevel.Function,  "post", Route = "sperrov1/pendinggame")]HttpRequestMessage req,
            [Inject(typeof(IGameRepository))]IGameRepository gameRepository,
            TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            string jsonContent = req.Content.ReadAsStringAsync().Result;

            Game game = JsonConvert.DeserializeObject<Game>(jsonContent);
            game.Status = GameApprovalStatus.Pending;

            gameRepository.Create(game);

            return req.CreateResponse(HttpStatusCode.OK);
        }
    }
}
