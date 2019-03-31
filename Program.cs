using DryIoc.Microsoft.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using DryIoc;
using DryIOC;

namespace DryIoc_AspNetCore3_Example
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
                })
                .UseServiceProviderFactory(new DryIocServiceProviderFactory())
                .ConfigureContainer<Container>((hostContext, container) =>
                {
                    container.Register<IHello, Hello>(Reuse.Transient);
                });
    }
}
