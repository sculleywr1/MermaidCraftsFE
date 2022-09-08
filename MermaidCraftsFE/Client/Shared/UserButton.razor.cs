using Microsoft.AspNetCore.Components;

namespace MermaidCraftsFE.Client.Shared
{
    public class UserButtonBase : ComponentBase
    {
        protected bool showUserMenu = false;

        protected string? UserMenuCssClass => showUserMenu ? "show-menu" : null;

        protected void ToggleUserMenu()
        {
            showUserMenu = !showUserMenu;
        }

        protected async Task HideUserMenu()
        {
            await Task.Delay(200);
            showUserMenu = false;
        }
    }
}
