using Myd.Client.Services.Configuration;

namespace Myd.Client.App.WinPhone.Services.Configuration
{   
    class WinPhoneConfigurationService : IConfigurationService
    {
        public string Get(string key)
        {
            switch (key)
            {
                case "WebApiUrl":
                    return "agasg";
                case "ClientId":
                    return "sagasg";
                case "ClientSecret":
                    return "asgasggasgas";
                default:
                    return null;
            }
        }
    }
}
