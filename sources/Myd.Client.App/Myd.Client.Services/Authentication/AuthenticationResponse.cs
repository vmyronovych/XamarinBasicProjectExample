using System.Collections.Generic;

namespace Myd.Client.Services.Authentication
{
    public class AuthenticationResponse
    {
        public string AccessToken { get; set; }
        public Dictionary<string, string> Claims { get; set; }
    }
}