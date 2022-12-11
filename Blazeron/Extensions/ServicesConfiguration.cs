namespace Blazeron.Extensions
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Defines the <see cref="ServicesConfiguration" />.
    /// </summary>
    public static class ServicesConfiguration
    {
        /// <summary>
        /// Configures the application settings.
        /// </summary>
        /// <param name="services">The services<see cref="IServiceCollection"/>.</param>
        /// <param name="configuration">The configuration<see cref="IConfiguration"/>.</param>
        /// <returns>The <see cref="IServiceCollection"/>.</returns>
        public static IServiceCollection ConfigureApplicationSettings(this IServiceCollection services, IConfiguration configuration)
        {
            //services.Configure<MockarooSettingsOptions>(configuration.GetSection(MockarooSettingsOptions.SECTION));
            //services.AddOptions<MockarooSettingsOptions>().Bind(configuration.GetSection(MockarooSettingsOptions.SECTION));

            return services;
        }
    }
}
