using Autofac;
using Myd.Client.App.Pages.Login;
using Myd.Client.Services.Authentication;
using Myd.Client.Services.Users;

namespace Myd.Client.App.Infrastructure
{
    class CommonDependenciesRegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<AuthenticationService>()
                .As<IAuthenticationService>()
                .SingleInstance();
            builder.RegisterType<UsersService>()
                .As<IUsersService>()
                .SingleInstance();
            builder.RegisterType<LoginPage>()
                .SingleInstance();
        }
    }
}
