using Microsoft.AspNetCore.Components;

namespace MermaidCraftsFE.Client.Shared
{
    public class HomeButtonBase : ComponentBase
    {
        [Inject] NavigationManager NavigationManager { get; set; }

        protected void GoToHome()
        {
            NavigationManager.NavigateTo("");
        }
    }
}
