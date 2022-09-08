using Blazored.LocalStorage;
using MermaidCraftsFE.Client.Models;
using MermaidCraftsFE.Client.Services.AuthService;
using Microsoft.AspNetCore.Components;

namespace MermaidCraftsFE.Client.Pages
{
    public class LoginBase : ComponentBase
    {
        [Inject] protected IAuthService AuthService { get; set; }
        [Inject] protected ILocalStorageService LocalStorageService { get; set; }
        [Inject] protected NavigationManager NavigationManager { get; set; }

        protected UserLogin user = new UserLogin();
        protected string errorMessage = string.Empty;

        protected async Task HandleLogin()
        {
            var result = await AuthService.Login(user);
            if (result.Success)
            {
                errorMessage = string.Empty;
                await LocalStorageService.SetItemAsync("authToken", result.Data);
                NavigationManager.NavigateTo("");
            }
            else
            {
                errorMessage = result.Message;
            }
        }
    }
}
