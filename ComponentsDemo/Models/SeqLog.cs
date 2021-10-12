
namespace ComponentsDemo.Models
{
    using Microsoft.Extensions.Logging;

    public class SeqLog
    {
        public LogLevel Level { get; set; }
        public string Message { get; set; }
        public string Jira { get; set; }
    }
}