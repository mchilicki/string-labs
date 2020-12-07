using Chilicki.StringLabs.Core.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chilicki.StringLabs.Core.Tests.DependencyInjection
{
    static class TestsDependencyInjection
    {
        public static IServiceProvider RunDependencyInjection()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            CoreDependencyInjection.RegisterDependencies(serviceCollection);
            IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();
            return serviceProvider;
        }
    }
}
