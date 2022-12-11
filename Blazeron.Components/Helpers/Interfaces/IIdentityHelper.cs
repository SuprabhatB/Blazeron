namespace Blazeron.Components.Helpers
{
    /// <summary>
    /// Defines the <see cref="IIdentityHelper" />.
    /// </summary>
    interface IIdentityHelper
    {
        /// <summary>
        /// Generates the element identifier if empty.
        /// </summary>
        /// <param name="existingId">The existingId<see cref="string"/>.</param>
        /// <param name="newId">The newId<see cref="string"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        string GenerateElementIdIfEmpty(string existingId, string newId);
    }
}
