﻿using Autofac;
using Myd.Client.App.WinPhone.Services;
using Myd.Client.App.WinPhone.Services.Configuration;
using Myd.Client.Services.Configuration;
using Myd.Client.Services.Infrastructure;
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
