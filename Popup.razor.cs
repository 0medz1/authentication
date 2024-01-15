using Microsoft.AspNetCore.Components;

namespace authentification.Pages
{
    public partial class Popup:ComponentBase
    {
        [Parameter]
        [SupplyParameterFromQuery]
        public int? Age { get; set; }
        [Parameter]
        [SupplyParameterFromQuery]
        public string? Email { get; set; }
        [Parameter]
        [SupplyParameterFromQuery]
        public string? Name { get; set; }
        
    }
}
