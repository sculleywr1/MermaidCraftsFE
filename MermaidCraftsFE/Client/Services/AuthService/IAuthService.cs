using MermaidCraftsFE.Client.Models;

namespace MermaidCraftsFE.Client.Services.AuthService
{
    public interface IAuthService
    {
        Task<ServiceResponse<string>> Login(UserLogin request);
        Task<ServiceResponse<int>> Register(UserRegister request);
        Task<ServiceResponse<bool>> ChangePassword(UserChangePassword request);
        Task<bool> IsUserAuthenticated();
    }
}
