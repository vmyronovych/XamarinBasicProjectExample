using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myd.Client.App.Services.Configuration
{
    public interface IConfigurationService
    {
        string Get(string key);
    }
}
