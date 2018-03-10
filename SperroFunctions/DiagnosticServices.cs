using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;
using SperroFunctions.DependencyInjection.DependencyInjection;
using SperroFunctions.Helpers;
using SperroFunctions.Interfaces;
using SperroFunctions.Types;

namespace SperroFunctions
{
    public static class DiagnosticServices
    {
        [FunctionName("DiagnosticServices")]
        public static HttpResponseMessage Run([HttpTrigger(AuthorizationLevel.Function, "get", Route = "sperrov1/diagnostics")]HttpRequestMessage req,
            [Inject(typeof(IPrizeRepository))]IPrizeRepository prizeRepository,
            TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            string rawFlags = req.GetQueryNameValuePairs()
               .FirstOrDefault(q => string.Compare(q.Key, "flags", true) == 0)
               .Value;

            List<string> flags = DiagnosticsHelper.Flags(rawFlags);

            var diagnostics = new List<DiagnosticInformation>();

            foreach (var flag in flags)
            {
                var diagnostic = new DiagnosticInformation()
                {
                    Timestamp = DateTime.Now,
                    Topic = flag,
                    Diagnostic = "Topic not found"
                };

                switch (flag)
                {
                    case "prizecount":
                        diagnostic.Diagnostic = string.Format("Full prize count: {0}", prizeRepository.Count);
                        break;
                    default:
                        break;
                }

                diagnostics.Add(diagnostic);
            }

            // Fetching the name from the path parameter in the request URL
            return req.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(diagnostics));
        }
    }
}
