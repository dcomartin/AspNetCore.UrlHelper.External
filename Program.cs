using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Demo
{           
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args);
        }

        private static IWebHost BuildWebHost(string[] args)
        {
            var webhost = WebHost.CreateDefaultBuilder(args)
                .SniffRouteData()
                .UseStartup<Startup>()
                .Build();
    
            var urlHelper = webhost.GetStaticUrlHelper("https://my.internal.service:48923/somepath");
            Console.WriteLine(urlHelper.Link(nameof(ValuesController), null));
            return webhost;
        }
    }
}
