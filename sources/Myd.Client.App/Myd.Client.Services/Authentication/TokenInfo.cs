using System;

namespace Myd.Client.Services.Authentication
{
    public class TokenInfo
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}