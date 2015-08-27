using Myd.Client.App.Services.Configuration;

namespace Myd.Client.App.WinPhone.Services.Configuration
{   
    class WinPhoneConfigurationService : IConfigurationService
    {
        public string Get(string key)
        {
            switch (key)
            {
                case "WebApiUrl":
                    return "agdsgd";
                case "ClientId":
                    return "asafasff";
                case "ClientSecret":
                    return "asfasfaf";
                default:
                    return null;
            }
        }
    }
}
