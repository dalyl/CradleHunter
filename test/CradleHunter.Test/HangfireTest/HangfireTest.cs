using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CradleHunter.Test.HangfireTest
{
    [TestClass]
    public class HangfireTest
    {
        [TestMethod]
        public void Configure()
        {

        }
    }

    //public class Startup
    //{
    //    // This method gets called by the runtime. Use this method to add services to the container.
    //    public void ConfigureServices(IServiceCollection services)
    //    {
    //        services.AddMvc().AddCookieTempDataProvider();
    //        services.Insert(0, ServiceDescriptor.Singleton(
    //            typeof(IConfigureOptions<AntiforgeryOptions>),
    //            new ConfigureOptions<AntiforgeryOptions>(options => options.CookieName = "<choose a name>")));
    //    }
    //    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    //    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    //    {
    //        app.UseDeveloperExceptionPage();
    //        app.UseStaticFiles();
    //        loggerFactory
    //            .AddConsole()
    //            .AddDebug();
    //        app.UseMvc(routes =>
    //        {
    //            routes.MapRoute(
    //                name: "default",
    //                template: "{controller=Home}/{action=Index}/{id?}");
    //        });
    //    }
    //    public static void Main(string[] args)
    //    {
    //        var host = new WebHostBuilder()
    //            .UseContentRoot(Directory.GetCurrentDirectory())
    //            .UseIISIntegration()
    //            .UseKestrel()
    //            .UseStartup<Startup>()
    //            .Build();
    //        host.Run();
    //    }
    //}
}
