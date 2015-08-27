using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Myd.Client.Services.Authentication;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Myd.Client.Services.Users
{
    public class UsersService : IUsersService
    {
        private readonly IAuthenticationService _authenticationService;

        public UsersService(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        public async Task<List<User>> GetUsersAsync(GetUsersRequest request)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _authenticationService.AccessToken.Token);
                var apiResponse = await httpClient.GetStringAsync("https://myd-dev-api-testing2.azurewebsites.net/api/users");
                var responseData = (JObject)JsonConvert.DeserializeObject(apiResponse);

                return responseData
                    .SelectToken("users")
                    .Select(user => new User
                {
                    Id = Guid.Parse(user["id"].Value<string>()),
                    FirstName = user["firstName"].Value<string>(),
                    LastName = user["lastName"].Value<string>()
                }).ToList();
            }
        }
    }
}