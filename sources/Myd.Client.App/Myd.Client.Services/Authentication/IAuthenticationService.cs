using System.Threading.Tasks;

namespace Myd.Client.Services.Authentication
{
    public interface IAuthenticationService
    {
        TokenInfo AccessToken { get; }
        Task AuthenticateAsync(AuthenticationResponseRequest request);
    }
}
