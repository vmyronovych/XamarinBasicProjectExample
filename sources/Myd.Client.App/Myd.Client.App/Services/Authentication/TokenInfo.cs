using System;

namespace Myd.Client.App.Services.Authentication
{
    public class TokenInfo
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}