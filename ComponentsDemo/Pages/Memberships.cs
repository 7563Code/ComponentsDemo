namespace ComponentsDemo.Pages
{
    using System.Net.Http.Json;
    using System.Text.Json;
    using Microsoft.AspNetCore.Components;

    using ComponentsDemo.Models;

    public partial class Memberships : ComponentBase
    {
        private int queryCount = 76;

        DurableResponse DurableResponse;

        public Memberships()
        {
            DurableResponse = JsonSerializer.Deserialize<DurableResponse>(
                GetDurableResponseAsString());
        }

        private string GetDurableResponseAsString() =>
            @"{
              ""name"": ""OrchAddRelationships"",
              ""instanceId"": ""c506947f731641cc9cdbde835a032689"",
              ""runtimeStatus"": ""Completed"",
              ""input"": {
                ""LastUpdatedBefore"": ""2000-01-01"",
                ""AccountType"": ""LN"",
                ""ConversionId"": ""CDFCU2021"",
                ""ConversionTimestamp"": ""2021-10-08T16:29:11.7263298+00:00"",
                ""OrchestrationInstanceId"": null,
                ""Take"": null
              },
              ""customStatus"": null,
              ""output"": {
                ""Strategy"": ""OrchAddRelationships"",
                ""Success"": true,
                ""Status"": {
                  ""OrchestrationStatus"": {
                    ""ExpectedCount"": 221,
                    ""ProcessedCount"": 221,
                    ""SuccessCount"": 54,
                    ""FailureCount"": 167
                  }
                }
              },
              ""createdTime"": ""2021-10-08T16:29:11Z"",
              ""lastUpdatedTime"": ""2021-10-08T16:29:49Z""
            }";
    }
}