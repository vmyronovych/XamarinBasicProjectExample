using Autofac;

namespace Myd.Client.Services.Infrastructure
{
    public interface IDependencyRegistrar
    {
        void RegisterDependencies(ContainerBuilder builder);
    }
}
