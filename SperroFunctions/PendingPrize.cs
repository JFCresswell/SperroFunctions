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
    public static class PendingPrize
    {
        [FunctionName("PendingPrize")]
        public static HttpResponseMessage Run([HttpTrigger(AuthorizationLevel.Function, "post", Route = "sperrov1/pendingprize")]HttpRequestMessage req,
            [Inject(typeof(IPrizeRepository))]IPrizeRepository prizeRepository,
            TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            string jsonContent = req.Content.ReadAsStringAsync().Result;

            Prize prize = JsonConvert.DeserializeObject<Prize>(jsonContent);
            prize.SubmitStatus = PrizeSubmitStatus.Pending;

            prizeRepository.Create(prize);

            // Fetching the name from the path parameter in the request URL
            return req.CreateResponse(HttpStatusCode.OK);
        }
    }
}
