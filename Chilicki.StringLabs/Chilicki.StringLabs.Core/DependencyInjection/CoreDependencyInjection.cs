using Chilicki.StringLabs.Core.Services;
using Chilicki.StringLabs.Core.Services.Base;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chilicki.StringLabs.Core.DependencyInjection
{
    public static class CoreDependencyInjection
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            services.AddTransient<ITeamsUrlService, TeamsUrlService>();
            services.AddTransient<IUrlExtractionService, UrlExtractionService>();
            services.AddTransient<IQuotationMarkReplacer, QuotationMarkReplacer>();
        }
    }
}
