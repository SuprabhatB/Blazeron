namespace Blazeron.Utilities.Extensions
{
    using System.Text.Json;

    /// <summary>
    /// Defines the <see cref="JsonExtension" />.
    /// </summary>
    public static class JsonExtension
    {
        /// <summary>
        /// Serializes the specified is case insensitive property name.
        /// </summary>
        /// <param name="value">The value<see cref="object"/>.</param>
        /// <param name="isCaseInsensitivePropertyName">The isCaseInsensitivePropertyName<see cref="bool"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string Serialize(this object value, bool isCaseInsensitivePropertyName = false)
        {
            if (value == null)
                return default;

            return JsonSerializer.Serialize(value, new JsonSerializerOptions { PropertyNameCaseInsensitive = isCaseInsensitivePropertyName });
        }

        /// <summary>
        /// Deserializes the specified is case insensitive property name.
        /// </summary>
        /// <typeparam name="T">.</typeparam>
        /// <param name="value">The value<see cref="string"/>.</param>
        /// <param name="isCaseInsensitivePropertyName">The isCaseInsensitivePropertyName<see cref="bool"/>.</param>
        /// <returns>The <see cref="T"/>.</returns>
        public static T Deserialize<T>(this string value, bool isCaseInsensitivePropertyName = false) where T : class
        {
            if (string.IsNullOrWhiteSpace(value))
                return default;

            return JsonSerializer.Deserialize<T>(value, new JsonSerializerOptions { PropertyNameCaseInsensitive = isCaseInsensitivePropertyName });
        }
    }
}
