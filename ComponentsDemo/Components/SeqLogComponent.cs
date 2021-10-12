namespace ComponentsDemo.Components
{
    using Microsoft.AspNetCore.Components;
    using ComponentsDemo.Models;
    using System.Threading.Tasks;

    public partial class SeqLogComponent : ComponentBase
    {
        private SeqLog seqLog;
        private string fullMessage;
        private string rowBackGround = "bg-light";

        [Parameter]
        public SeqLog SeqLog { get; set; }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            seqLog = SeqLog;
            fullMessage = GenerateFullMessage(seqLog);
        }

        private void UpdateJiraNumber(string jiraNumber)
        {
            seqLog.Jira = jiraNumber;
            fullMessage = GenerateFullMessage(seqLog);
            rowBackGround = "bg-info";
            //this.StateHasChanged();
        }

        private string GenerateFullMessage(SeqLog seqLog) =>
            $"{seqLog.Jira} - {seqLog.Message}";
    }
}
