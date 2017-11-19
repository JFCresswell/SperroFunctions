using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;
using SperroFunctions.Interfaces;
using SperroFunctions.DependencyInjection.DependencyInjection;

namespace SperroFunctions
{
    public static class Customers
    {
        [FunctionName("Customers")]
        public static HttpResponseMessage Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "sperrov1/customers")]HttpRequestMessage req,
             [Inject(typeof(ICustomerRepository))]ICustomerRepository customerRepository,
            TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            return req.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(customerRepository.FindAll()));
        }
    }
}
