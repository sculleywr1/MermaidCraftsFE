using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace MermaidCraftsFE.Client.Shared
{
    public class UserButtonBase : ComponentBase
    {
        [Inject] ILocalStorageService LocalStorage { get; set; }
        [Inject] AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [Inject] protected NavigationManager navigationManager { get; set; }

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

        protected async Task Logout()
        {
            await LocalStorage.RemoveItemAsync("authToken");
            await AuthenticationStateProvider.GetAuthenticationStateAsync();
            navigationManager.NavigateTo("");
        }
    }
}
