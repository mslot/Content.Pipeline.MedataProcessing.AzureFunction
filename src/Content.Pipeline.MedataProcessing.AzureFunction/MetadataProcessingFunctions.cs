using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Content.Pipeline.MedataProcessing.AzureFunction
{
    public class MetadataProcessingFunctions
    {
        [FunctionName("MetadataProcessingFunction")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {

            return new OkObjectResult("Metadata processing function");
        }
    }
}
