namespace Blazeron
{
    using Blazeron.Components.Localization;
    using Microsoft.AspNetCore.Components;
    using Microsoft.Extensions.Localization;

    /// <summary>
    /// Defines the <see cref="PageComponentsBase" />.
    /// </summary>
    public abstract class PageComponentsBase : ComponentBase
    {
        /// <summary>
        /// Gets or sets the navigationManager.
        /// </summary>
        [Inject] public NavigationManager Navigation { get; set; }

        /// <summary>
        /// Gets or sets the localizer.
        /// </summary>
        [Inject] public IStringLocalizer<BlazeronLocale> Localizer { get; set; }
    }
}
