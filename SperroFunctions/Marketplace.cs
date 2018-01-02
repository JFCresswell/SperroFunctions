using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;
using SperroFunctions.DependencyInjection.DependencyInjection;
using SperroFunctions.Interfaces;

namespace SperroFunctions
{
    public static class Marketplace
    {
        [FunctionName("Marketplace")]
        public static HttpResponseMessage Run([HttpTrigger(AuthorizationLevel.Function, "get", Route = "sperrov1/marketplace/{id}")]HttpRequestMessage req,
            [Inject(typeof(IMarketplaceRepository))]IMarketplaceRepository marketplaceRepository,
            int id,
            TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            // Fetching the name from the path parameter in the request URL
            return req.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(marketplaceRepository.GetSnapshot(id)));
        }
    }
}
