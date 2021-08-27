using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSettingsPractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();

                    //This section was taken from:
                    // https://dev.to/j_sakamoto/how-to-deal-with-the-http-404-content-foo-bar-css-not-found-when-using-razor-component-package-on-asp-net-core-blazor-app-aai
                    //Without this section, non-Development environments weren't importing css, navmenu, etc.
                    //This corrected the issue, but not sure if MS has deployed better solution

                    // Add this "ConfigureAppConfiguration" method calling.
                    webBuilder.ConfigureAppConfiguration((ctx, cb) =>
                    {
                        // Please specify the condition that is true only when
                        //    the application is running on your development environment.
                        //    Notice that excludes the case that the environment is "Development".
                        if (!ctx.HostingEnvironment.IsDevelopment())
                        {
                            // This call inserts "StaticWebAssetsFileProvider" into
                            //    the static file middleware.
                            StaticWebAssetsLoader.UseStaticWebAssets(
                              ctx.HostingEnvironment,
                              ctx.Configuration);
                        }
                    });
                });
    }
}
