using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;

namespace Content.Pipeline.MedataProcessing.AzureFunction
{
    public class MetadataProcessingFunctions
    {
        [FunctionName("MetadataProcessingFunction")]
        public void Run(
        [ServiceBusTrigger("metadata-topic","MetadataProcessingFunctionSubscription", Connection = "Servicebus:ServicebusConnectionString")]
        string myQueueItem,
        Int32 deliveryCount,
        DateTime enqueuedTimeUtc,
        string messageId,
        ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
            log.LogInformation($"EnqueuedTimeUtc={enqueuedTimeUtc}");
            log.LogInformation($"DeliveryCount={deliveryCount}");
            log.LogInformation($"MessageId={messageId}");
        }
    }
}
