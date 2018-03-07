using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;
using SperroFunctions.Helpers;

namespace SperroFunctions
{
    public static class DiagnosticServices
    {
        [FunctionName("DiagnosticServices")]
        public static HttpResponseMessage Run([HttpTrigger(AuthorizationLevel.Function, "get", Route = "sperrov1/diagnostics")]HttpRequestMessage req, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            string flags = req.GetQueryNameValuePairs()
               .FirstOrDefault(q => string.Compare(q.Key, "flags", true) == 0)
               .Value;

            // Fetching the name from the path parameter in the request URL
            return req.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(DiagnosticsHelper.Diagnostics(flags)));
        }
    }
}
