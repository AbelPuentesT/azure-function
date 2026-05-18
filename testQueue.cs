using System;
using Azure.Storage.Queues.Models;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Company.FunctionApp1;

public class testQueue
{
    private readonly ILogger<testQueue> _logger;

    public testQueue(ILogger<testQueue> logger)
    {
        _logger = logger;
    }

    [Function(nameof(testQueue))]
    public void Run([QueueTrigger("myqueue-items", Connection = "")] QueueMessage message)
    {
        _logger.LogInformation("C# Queue trigger function processed: {messageText}", message.MessageText);
    }
}