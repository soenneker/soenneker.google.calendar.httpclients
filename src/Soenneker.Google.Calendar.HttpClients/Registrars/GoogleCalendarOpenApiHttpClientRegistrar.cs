using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Google.Calendar.HttpClients.Abstract;
using Soenneker.Utils.HttpClientCache.Registrar;

namespace Soenneker.Google.Calendar.HttpClients.Registrars;

/// <summary>
/// Registers the OpenAPI HttpClient wrapper for dependency injection.
/// </summary>
public static class GoogleCalendarOpenApiHttpClientRegistrar
{
    /// <summary>
    /// Adds <see cref="GoogleCalendarOpenApiHttpClient"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddGoogleCalendarOpenApiHttpClientAsSingleton(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddSingleton<IGoogleCalendarOpenApiHttpClient, GoogleCalendarOpenApiHttpClient>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="GoogleCalendarOpenApiHttpClient"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddGoogleCalendarOpenApiHttpClientAsScoped(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddScoped<IGoogleCalendarOpenApiHttpClient, GoogleCalendarOpenApiHttpClient>();

        return services;
    }
}
