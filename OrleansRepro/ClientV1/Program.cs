using Common;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Orleans;
using Orleans.Configuration;
using Orleans.Versions.Compatibility;
using Orleans.Versions.Selector;

namespace ClientV1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var clientHost = await Host.CreateDefaultBuilder()
                 .UseOrleansClient(builder => builder
                    .UseLocalhostClustering())
                .StartAsync();

            var clusterClient = clientHost.Services.GetRequiredService<IClusterClient>();

            var grain = clusterClient.GetGrain<IFoo>("grain key");
            
            var result = await grain.Bar1();            
        }
    }
}