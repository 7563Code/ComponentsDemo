namespace ComponentsDemo.Pages
{
    using System.Collections.Generic;

    using Microsoft.Extensions.Logging;

    using ComponentsDemo.Models;

    public partial class ConversionResultPage
    {
        private List<SeqLog> SeqLogResults;

        public ConversionResultPage()
        {
            SeqLogResults = new List<SeqLog>
            {
                new SeqLog
                {
                    Level = LogLevel.Information,
                    Message = "MembershipCreation started processing 7076 rims.",
                    Jira = "ACQ-123"
                },                
                new SeqLog
                {
                    Level = LogLevel.Error,
                    Message = "RM_ACCT: Unable to create Rm_AcctKey: 12345",
                    Jira = "ACQ-123"
                },
                new SeqLog
                {
                    Level = LogLevel.Error,
                    Message = "RM_Address: Unable to create Rm_Address due to null AddressId.",
                    Jira = "ACQ-234"
                },
            };
        }
    }
}
