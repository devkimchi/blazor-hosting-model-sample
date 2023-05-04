using Microsoft.AspNetCore.Components;

namespace ServerApp.Components
{
    public partial class SurveyPropmtComponent : ComponentBase
    {
        // Demonstrates how a parent component can supply parameters
        [Parameter]
        public string? Title { get; set; }
    }
}