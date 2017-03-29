using System;
using System.Collections.Generic;
using System.Text;
using Hangfire;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using CradleHunter.Core;

namespace CradleHunter.Hangfire
{
    public static class Configure
    {

        public static void AddHangfire(IServiceCollection services,string connection)
        {
            services.AddHangfire(x => x.UseSqlServerStorage(connection));
            services.AddTransient<IMonitor, HangfireMonitor>();
            ServiceManager.Reset(services);
        }

        public static void UseHangfireCradleHunter(IApplicationBuilder app)
        {
             app.UseHangfireServer();
        }


    }
}
