using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Myd.Client.App.Pages.Login;
using Myd.Client.App.Services.Authentication;
using Myd.Client.App.Services.Users;

namespace Myd.Client.App
{
    class AppModule : Module
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
