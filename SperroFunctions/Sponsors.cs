using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using SperroFunctions.DependencyInjection.DependencyInjection;
using SperroFunctions.Interfaces;
using Newtonsoft.Json;

namespace SperroFunctions
{
    public static class Sponsors
    {
        [FunctionName("Sponsors")]
        public static HttpResponseMessage Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "sperrov1/sponsors")]HttpRequestMessage req,
            [Inject(typeof(ISponsorRepository))]ISponsorRepository sponsorRepository,
            TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            // Fetching the name from the path parameter in the request URL
            return req.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(sponsorRepository.FindAll()));
        }
    }
}
