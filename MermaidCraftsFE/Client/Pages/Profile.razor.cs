using MermaidCraftsFE.Client.Models;
using MermaidCraftsFE.Client.Services.AuthService;
using Microsoft.AspNetCore.Components;

namespace MermaidCraftsFE.Client.Pages
{
    public class ProfileBase : ComponentBase
    {
        [Inject] IAuthService AuthService { get; set; }
        protected UserChangePassword request = new UserChangePassword();

        protected string message = string.Empty;

        protected async Task ChangePassword()
        {
            var result = await AuthService.ChangePassword(request);
            message = result.Message;
        }
    }
}
