using API_JWT.Models;

namespace API_JWT.Services
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(RegistrationModel model);
        Task<AuthModel> GetTokenAsync(TokenRequestModel model);

    }
}
