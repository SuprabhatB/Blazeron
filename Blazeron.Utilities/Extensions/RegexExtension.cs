namespace Blazeron.Utilities.Extensions
{
    using System.Text.RegularExpressions;

    /// <summary>
    /// Defines the <see cref="RegexExtension" />.
    /// </summary>
    public static class RegexExtension
    {
        /// <summary>
        /// Determines whether [is match alphabets and digits].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        ///   <c>true</c> if [is match alphabets and digits] [the specified value]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsMatchAlphabetsAndDigits(this string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return default;

            var regex = new Regex(@"[^a-zA-Z0-9\s]");

            return regex.IsMatch(value);
        }
    }
}
