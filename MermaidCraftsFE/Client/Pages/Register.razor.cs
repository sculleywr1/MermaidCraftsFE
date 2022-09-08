using MermaidCraftsFE.Client.Models;
using Microsoft.AspNetCore.Components;

namespace MermaidCraftsFE.Client.Pages
{
    public class RegisterBase : ComponentBase
    {

        public UserRegister user = new UserRegister();

        public void HandleRegistration()
        {
            Console.WriteLine($"Register User with the Email {user.Email}");
        }

    }
}
