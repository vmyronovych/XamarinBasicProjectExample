using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Myd.Client.App.Services.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Myd.Client.App.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IConfigurationService _configurationService;

        public AuthenticationService(IConfigurationService configurationService)
        {
            _configurationService = configurationService;
        }

        public TokenInfo AccessToken { get; private set; }

        public async Task AuthenticateAsync(AuthenticationResponseRequest request)
        {
            using (var client = new HttpClient())
            {
                var apiResponse = await client.PostAsync(_configurationService.Get("WebApiUrl"),
                    new FormUrlEncodedContent(new Dictionary<string, string>
                    {
                        { "grant_type", "password"},
                        { "username", request.Login},
                        { "password", request.Password},
                        { "scope", "myd"},
                        { "client_id", _configurationService.Get("ClientId")},
                        { "client_secret", _configurationService.Get("ClientSecret")},
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