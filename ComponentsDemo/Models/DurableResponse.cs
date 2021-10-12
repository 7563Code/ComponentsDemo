namespace ComponentsDemo.Models
{
    using System;

    public class DurableResponse
    {
        public string name { get; set; }
        public string instanceId { get; set; }
        public string runtimeStatus { get; set; }
        public Input input { get; set; }
        public object customStatus { get; set; }
        public Output output { get; set; }
        public DateTime createdTime { get; set; }
        public DateTime lastUpdatedTime { get; set; }
    }

    public class Input
    {
        public string LastUpdatedBefore { get; set; }
        public string AccountType { get; set; }
        public string ConversionId { get; set; }
        public DateTime ConversionTimestamp { get; set; }
        public object OrchestrationInstanceId { get; set; }
        public object Take { get; set; }
    }

    public class Output
    {
        public string Strategy { get; set; }
        public bool Success { get; set; }
        public Status Status { get; set; }
    }

    public class Status
    {
        public Orchestrationstatus OrchestrationStatus { get; set; }
    }

    public class Orchestrationstatus
    {
        public int ExpectedCount { get; set; }
        public int ProcessedCount { get; set; }
        public int SuccessCount { get; set; }
        public int FailureCount { get; set; }
    }

}
