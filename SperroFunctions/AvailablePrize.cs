using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using SperroFunctions.DependencyInjection.DependencyInjection;
using SperroFunctions.Interfaces;

namespace SperroFunctions.Models
{
    public static class AvailablePrize
    {
        [FunctionName("AvailablePrize")]
        public static HttpResponseMessage Run([HttpTrigger(AuthorizationLevel.Function, "get", Route = "sperrov1/prizes/prize/{id}")]HttpRequestMessage req,
            [Inject(typeof(IPrizeRepository))]IPrizeRepository prizeRepository,
            int id,
            TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            // Fetching the name from the path parameter in the request URL
            return req.CreateResponse(HttpStatusCode.OK, prizeRepository.GetById(id));
        }
    }
}
