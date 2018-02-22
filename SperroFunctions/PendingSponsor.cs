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
    public static class PendingSponsor
    {
        [FunctionName("Sponsor")]
        public static HttpResponseMessage Run([HttpTrigger(AuthorizationLevel.Function, "post", Route = "sperrov1/pendingsponsor")]HttpRequestMessage req,
             [Inject(typeof(ISponsorRepository))]ISponsorRepository sponsorRepository,
             TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            string jsonContent = req.Content.ReadAsStringAsync().Result;

            Sponsor sponsor = JsonConvert.DeserializeObject<Sponsor>(jsonContent);
            sponsor.Status = SponsorStatus.Pending;

            sponsorRepository.Create(sponsor);

            // Fetching the name from the path parameter in the request URL
            return req.CreateResponse(HttpStatusCode.OK);
        }
    }
}
