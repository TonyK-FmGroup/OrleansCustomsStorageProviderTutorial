using GrainStorageProviders;
using Microsoft.Extensions.Hosting;
using Orleans.Hosting;

Console.WriteLine("Orleans silo starting... ");

var host = Host.CreateDefaultBuilder()
            .UseOrleans((ctx, silo) =>
            {
                silo.UseLocalhostClustering();
                silo.AddCustomStorage("customstore");
            })
            .Build();


await host.StartAsync();

Console.WriteLine("Press any key to exit...");
Console.ReadKey();

await host.StopAsync();