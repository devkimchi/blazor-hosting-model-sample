using Microsoft.AspNetCore.Components;

namespace ServerApp.Components
{
    public partial class CounterComponent : ComponentBase
    {
        protected int CurrentCount { get; set; } = 0;

        private void IncrementCount()
        {
            this.CurrentCount++;
        }
    }
}