using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Myd.Client.App.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        public TokenInfo AccessToken { get; private set; }

        public async Task AuthenticateAsync(AuthenticationResponseRequest request)
        {
            using (var client = new HttpClient())
            {
                var apiResponse = await client.PostAsync("https://myd-dev-login-testing2.azurewebsites.net/connect/token",
                    new FormUrlEncodedContent(new Dictionary<string, string>
                    {
                        { "grant_type", "password"},
                        { "username", request.Login},
                        { "password", request.Password},
                        { "scope", "blabla"},
                        { "client_id", "blabla"},
                        { "client_secret", "blablaa"},
                    })).ConfigureAwait(false);

                var responseText = await apiResponse.Content.ReadAsStringAsync();

                var responseData = (JObject)JsonConvert.DeserializeObject(responseText);

                AccessToken = new TokenInfo
                {
                    Token = responseData.SelectToken("access_token").ToString()
                };
            }
        }
    }
}