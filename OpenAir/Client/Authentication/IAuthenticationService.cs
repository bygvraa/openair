using OpenAir.Shared.Models;
using System.Threading.Tasks;

namespace OpenAir.Client.Authentication
{
    public interface IAuthenticationService
    {
        Task<AuthenticatedUserModel> Login(AuthenticationUserModel userForAuthentication);
        Task Logout();
    }
}