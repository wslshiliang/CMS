using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace SelfSameCMS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
             Host.CreateDefaultBuilder(args)  //??????????????
             .ConfigureWebHostDefaults(webBuilder =>
             {
                 webBuilder.UseStartup<Startup>();
             });


        /// <summary>
        ///  //??????????json???
        /// </summary> 
        //public static IWebHostBuilder CreateHostBuilder(string[] args) =>
        //        WebHost.CreateDefaultBuilder(args) 
        //       .ConfigureAppConfiguration((hostingContext, config) => {
        //           var env = hostingContext.HostingEnvironment;
        //           // config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
        //           // .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true)
        //           //reloadOnChange?true???锟揭侊拷??????????????
        //           config.AddJsonFile("Content.json", optional: false, reloadOnChange: false);
        //             // .AddEnvironmentVariables();
        //       })
        //    .UseStartup<Startup>();

    }
}
