using Microsoft.Extensions.Hosting;
using Orleans.Configuration;
using Orleans.Versions.Compatibility;
using Orleans.Versions.Selector;
using System.Net;

namespace SiloV2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var siloHostBuilder = Host.CreateDefaultBuilder()
                .UseOrleans(builder => builder
                    .UseLocalhostClustering()
                    .Configure<GrainVersioningOptions>(o =>
                    {
                        o.DefaultVersionSelectorStrategy = nameof(LatestVersion);
                        o.DefaultCompatibilityStrategy = nameof(BackwardCompatible);
                    }));

            await siloHostBuilder.RunConsoleAsync();
        }
    }
}