using Autofac;
using Myd.Client.App.Services;
using Myd.Client.App.Services.Configuration;
using Myd.Client.App.WinPhone.Services;
using Myd.Client.App.WinPhone.Services.Configuration;
using Xamarin.Forms;

[assembly: Dependency(typeof(AppDependencyRegistrar))]
namespace Myd.Client.App.WinPhone.Services
{
    class AppDependencyRegistrar : IDependencyRegistrar
    {
        public void RegisterDependencies(ContainerBuilder builder)
        {   
            builder.RegisterType<WinPhoneConfigurationService>()
                .As<IConfigurationService>()
                .SingleInstance();
        }
    }
}
