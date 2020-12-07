using Chilicki.StringLabs.Core;
using Chilicki.StringLabs.Core.DependencyInjection;
using Chilicki.StringLabs.Core.Services.Base;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chilicki.StringLabs
{
    class ProgramService
    {
        public void Run(string teamsMeetingUrl)
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            CoreDependencyInjection.RegisterDependencies(serviceCollection);
            IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

            var teamsUrlService = serviceProvider.GetService<ITeamsUrlService>();
            teamsUrlService.ExtractUrl(teamsMeetingUrl);
        }
    }
}
