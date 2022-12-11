namespace Blazeron.Extensions
{
    using Microsoft.AspNetCore.Components;
    using Microsoft.AspNetCore.WebUtilities;
    using System;

    /// <summary>
    /// Defines the <see cref="NavigationManagerExtensions" />.
    /// </summary>
    public static class NavigationManagerExtensions
    {
        /// <summary>
        /// Tries the get query string.
        /// </summary>
        /// <typeparam name="T">.</typeparam>
        /// <param name="navManager">The navManager<see cref="NavigationManager"/>.</param>
        /// <param name="key">The key<see cref="string"/>.</param>
        /// <param name="value">The value<see cref="T"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public static bool TryGetQueryString<T>(this NavigationManager navManager, string key, out T value)
        {
            var uri = navManager.ToAbsoluteUri(navManager.Uri);

            if (QueryHelpers.ParseQuery(uri.Query).TryGetValue(key, out var valueFromQueryString))
            {
                if (typeof(T) == typeof(int) && int.TryParse(valueFromQueryString, out var valueAsInt))
                {
                    value = (T)(object)valueAsInt;
                    return true;
                }

                if (typeof(T) == typeof(string))
                {
                    value = (T)(object)valueFromQueryString.ToString();
                    return true;
                }

                if (typeof(T) == typeof(decimal) && decimal.TryParse(valueFromQueryString, out var valueAsDecimal))
                {
                    value = (T)(object)valueAsDecimal;
                    return true;
                }
            }

            value = default;

            return false;
        }

        /// <summary>
        /// Tries the create URI.
        /// </summary>
        /// <param name="navManager">The navManager<see cref="NavigationManager"/>.</param>
        /// <param name="path">The path<see cref="string"/>.</param>
        /// <param name="query">The query<see cref="string"/>.</param>
        /// <param name="fragment">The fragment<see cref="string"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string TryCreateURI(this NavigationManager navManager, string path, string query, string fragment)
        {
            var uBuild = new UriBuilder(navManager.BaseUri)
            {
                Path = path,
                Query = query,
                Fragment = fragment
            };

            return uBuild.Uri.ToString();
        }
    }
}
