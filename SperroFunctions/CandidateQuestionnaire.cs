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
    public static class CandidateQuestionnaire
    {
        [FunctionName("CandidateQuestionnaire")]
        public static HttpResponseMessage Run([HttpTrigger(AuthorizationLevel.Function, "post", Route = "sperrov1/candidatequestionnaire")]HttpRequestMessage req,
          [Inject(typeof(IQuestionnaireRepository))]IQuestionnaireRepository questionnaireRepository,
          TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            //questionnaireRepository.UpdateQuestionnaire(questionnaire);
            string jsonContent = req.Content.ReadAsStringAsync().Result;

            Questionnaire questionnaire = JsonConvert.DeserializeObject<Questionnaire>(jsonContent);

            questionnaireRepository.Create(questionnaire);

            // Fetching the name from the path parameter in the request URL
            return req.CreateResponse(HttpStatusCode.OK);
        }
    }
}
