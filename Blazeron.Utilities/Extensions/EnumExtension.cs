namespace Blazeron.Utilities.Extensions
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Reflection;

    /// <summary>
    /// Defines the <see cref="EnumExtension" />.
    /// </summary>
    public static class EnumExtension
    {
        /// <summary>
        /// Gets the display name.
        /// </summary>
        /// <param name="value">The value<see cref="Enum"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string GetDisplayName(this Enum value)
        {
            var displayAttribute = value.GetType()
                                        .GetMember(value.ToString())
                                        .First()
                                        .GetCustomAttribute<DisplayAttribute>();

            var displayName = value.ToString();

            if (displayAttribute != default) { displayName = displayAttribute.GetName(); }

            return displayName;
        }
    }
}
