namespace Blazeron.Utilities.Extensions
{
    using System.Globalization;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Defines the <see cref="TextExtension" />.
    /// </summary>
    public static class TextExtension
    {
        /// <summary>
        /// Converts to titlecase.
        /// </summary>
        /// <param name="value">The value<see cref="string"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string ToTitleCase(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return default;

            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
        }

        /// <summary>
        /// Converts to camelcase.
        /// </summary>
        /// <param name="value">The value<see cref="string"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string ToCamelCase(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return default;

            return char.ToLowerInvariant(value[0]) + value.Substring(1);
        }

        /// <summary>
        /// Removes the white spaces.
        /// </summary>
        /// <param name="value">The value<see cref="string"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string RemoveWhiteSpaces(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return default;

            return Regex.Replace(value, @"\s+", " ").Trim();
        }

        /// <summary>
        /// Converts to sentencecase.
        /// </summary>
        /// <param name="value">The value<see cref="string"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string ToSentenceCase(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return default;

            return Regex.Replace(value, "[a-z][A-Z]", m => $"{m.Value[0]} {char.ToUpper(m.Value[1])}");
        }

        /// <summary>
        /// Determines whether this instance has value.
        /// </summary>
        /// <param name="value">The value<see cref="string"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public static bool HasValue(this string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }
    }
}
