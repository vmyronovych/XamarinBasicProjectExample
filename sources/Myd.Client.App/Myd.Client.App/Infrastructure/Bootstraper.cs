using Autofac;
using Myd.Client.App.Services;
using Xamarin.Forms;

namespace Myd.Client.App.Infrastructure
{
    public static class Bootstraper
    {
        public static IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<CommonDependenciesRegistrationModule>();
            DependencyService.Get<IDependencyRegistrar>().RegisterDependencies(builder);
            var container = builder.Build();
            return container;
        }
    }
}