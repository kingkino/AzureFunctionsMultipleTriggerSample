using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace MultipleTriggerSample
{
    public static class TimerTriggerFunction
    {
        [FunctionName("TimerTriggerFunction")]
        public static void Run([TimerTrigger("0 */1 * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"{Logic.Logic.GetMessage(3)}:{DateTime.UtcNow.AddHours(9)}");
        }
    }
}
