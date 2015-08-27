using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace Myd.Client.App.Services
{
    public interface IDependencyRegistrar
    {
        void RegisterDependencies(ContainerBuilder builder);
    }
}
