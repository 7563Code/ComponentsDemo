namespace ComponentsDemo.Components
{
    using Microsoft.AspNetCore.Components;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public partial class JiraComponent : ComponentBase
    {
        private string jiraNumber;

        [Parameter]
        public string JiraNumber { get; set; }

        [Parameter]
        public EventCallback<string> JiraNumberChange { get; set; }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            jiraNumber = JiraNumber;
        }

        private void OnJiraNumberChange(ChangeEventArgs args)
        {
            jiraNumber = args.Value.ToString();
            JiraNumberChange.InvokeAsync(jiraNumber);
        }
    }
}
