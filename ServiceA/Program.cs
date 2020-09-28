using System;
using System.IO;

using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

using ServiceA.Application;

namespace ServiceA.Host
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(VersionRegistry.Value);
            WebHost.CreateDefaultBuilder(args).UseStartup<Startup>().Build().Run();
        }

    }
}
