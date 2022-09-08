using MermaidCraftsFE.Server.Models;

namespace MermaidCraftsFE.Server.DAO.AuthService
{
    public interface IAuthService
    {
        Task<ServiceResponse<int>> Register(User user, string password);
        Task<bool> UserExists(string email);
        Task<ServiceResponse<string>> Login(string email, string password);
    }
}
