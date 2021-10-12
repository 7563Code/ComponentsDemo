namespace ComponentsDemo.Components
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;

    public partial class SlotComponent : ComponentBase
    {
        private List<string> slots = new List<string>
        {
            "Local",
            "Dev",
            "Test",
            "Production"
        };

        private string chosenSlot = null;
        private bool isCheckingHealth = false;
        private string healthCheckIndicator = "btn-outline-warning";

        private void OnSlotChanged(ChangeEventArgs args) 
        {
            chosenSlot = args.Value.ToString();
            Console.WriteLine($"{chosenSlot} was selected.");
        }

        private async void GetHealthCheckAsync()
        {
            isCheckingHealth = true;
            await Task.Delay(2000);
            healthCheckIndicator = "btn-outline-success";
            isCheckingHealth = false;
            this.StateHasChanged();
        }
    }
}
