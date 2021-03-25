using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Web;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class SystemWebShimExtensions
    {
        public static SystemWebShimBuilder AddSystemWebShim(IServiceCollection services)
        {
            services.TryAddTransient<IStartupFilter, SystemWebShimStartupFilter>();

            return new SystemWebShimBuilder(services);
        }

        private class SystemWebShimStartupFilter : IStartupFilter
        {
            public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
                => builder => builder.Use((ctx, next) =>
                {
                    HttpContext.Current = new HttpContext(ctx);

                    return next();
                });
        }
    }
}
