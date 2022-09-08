using MermaidCraftsFE.Client.Models;
using MermaidCraftsFE.Client.Services.AuthService;
using Microsoft.AspNetCore.Components;

namespace MermaidCraftsFE.Client.Pages
{
    public class RegisterBase : ComponentBase
    {
        [Inject] protected IAuthService AuthService { get; set; }
        public UserRegister user = new UserRegister();

        protected string message = string.Empty;
        protected string messageCssClass = string.Empty;

        protected async Task HandleRegistration()
        {
            var result = await AuthService.Register(user);
            message = result.Message;
            if (result.Success)
            {
                messageCssClass = "text-success";
            }
            else
            {
                messageCssClass = "text-danger";
            }
        }

    }
}
