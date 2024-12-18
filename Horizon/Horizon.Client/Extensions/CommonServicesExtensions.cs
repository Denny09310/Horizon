using Radzen;

namespace Horizon.Client.Extensions;

public static class CommonServicesExtensions
{
    public static IServiceCollection AddCommonServices(this IServiceCollection services)
    {
        services.AddRadzenComponents();
        return services;
    }
}
