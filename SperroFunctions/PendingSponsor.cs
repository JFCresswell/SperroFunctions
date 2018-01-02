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
    public static class PendingSponsor
    {
        [FunctionName("Sponsor")]
        public static HttpResponseMessage Run([HttpTrigger(AuthorizationLevel.Function, "post", Route = "sperrov1/sponsors/pendingsponsor/{sponsor}")]HttpRequestMessage req,
             [Inject(typeof(ISponsorRepository))]ISponsorRepository sponsorRepository,
             Sponsor sponsor,
             TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            sponsorRepository.Create(sponsor);

            // Fetching the name from the path parameter in the request URL
            return req.CreateResponse(HttpStatusCode.OK);
        }
    }
}
