namespace Blazeron.Components.Extensions
{
    using Blazeron.Components.Helpers;
    using Blazeron.Utilities.Helpers;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Defines the <see cref="ServiceExtensions" />.
    /// </summary>
    public static class ServiceExtensions
    {
        /// <summary>
        /// Adds the blazeron.
        /// </summary>
        /// <param name="services">The services<see cref="IServiceCollection"/>.</param>
        public static void AddBlazeron(this IServiceCollection services)
        {
            services.AddSingleton<IIdGenerator, IdGenerator>();
            services.AddSingleton<IIdentityHelper, IdentityHelper>();
        }
    }
}
