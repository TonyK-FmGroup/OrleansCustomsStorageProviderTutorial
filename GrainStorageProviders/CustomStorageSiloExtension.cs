using Microsoft.Extensions.DependencyInjection;
using Orleans.Hosting;
using Orleans.Runtime;
using Orleans.Storage;

namespace GrainStorageProviders;

public static class CustomStorageSiloExtension
{
    public static ISiloBuilder AddCustomStorage(this ISiloBuilder builder, string providerName)
    {
        return builder.ConfigureServices(services =>
        {
            services.AddCustomStorage(providerName);
        });
    }

    public static IServiceCollection AddCustomStorage(this IServiceCollection services, string providerName)
    {
        return services.AddSingletonNamedService<IGrainStorage>(providerName, (s, n) =>
                s.GetRequiredServiceByName<IGrainStorage>(n));
    }
}
