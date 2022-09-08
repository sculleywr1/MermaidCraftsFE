using Blazored.LocalStorage;
using Microsoft.AspNetCore.WebUtilities;
using MermaidCraftsFE.Client.Models;
using MermaidCraftsFE.Client.Services.AuthService;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace MermaidCraftsFE.Client.Pages
{
    public class LoginBase : ComponentBase
    {
        [Inject] protected IAuthService AuthService { get; set; }
        [Inject] protected ILocalStorageService LocalStorageService { get; set; }
        [Inject] protected NavigationManager NavigationManager { get; set; }
        [Inject] protected AuthenticationStateProvider AuthenticationStateProvider { get; set; }

        protected UserLogin user = new UserLogin();
        protected string errorMessage = string.Empty;
        protected string returnUrl = string.Empty;

        protected override void OnInitialized()
        {
            var uri = NavigationManager.ToAbsoluteUri(NavigationManager.Uri);

            if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("returnUrl", out var url))
            {
                returnUrl = url;
            }
        }

        protected async Task HandleLogin()
        {
            var result = await AuthService.Login(user);
            if (result.Success)
            {
                errorMessage = string.Empty;
                await LocalStorageService.SetItemAsync("authToken", result.Data);
                await AuthenticationStateProvider.GetAuthenticationStateAsync();
                NavigationManager.NavigateTo(returnUrl);
            }
            else
            {
                errorMessage = result.Message;
            }
        }
    }
}
