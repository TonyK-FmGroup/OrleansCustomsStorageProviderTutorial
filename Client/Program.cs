using Grains;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Orleans;
using Orleans.Hosting;

Console.WriteLine("Starting stock simulator...");

var host = Host.CreateDefaultBuilder()
                .UseOrleansClient((ctx, client) =>
                {
                    client.UseLocalhostClustering();
                })
                .Build();
host.Start();

var clusterClient = host.Services.GetRequiredService<IClusterClient>();

var user = clusterClient.GetGrain<IUserGrain>("me");
await user.SetName("Tony");