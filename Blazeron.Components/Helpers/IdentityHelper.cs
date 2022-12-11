namespace Blazeron.Components.Helpers
{
    using Blazeron.Utilities.Helpers;
    using EnsureThat;

    /// <summary>
    /// Defines the <see cref="IdentityHelper" />.
    /// </summary>
    internal class IdentityHelper : IIdentityHelper
    {
        /// <summary>
        /// The identifier generator.
        /// </summary>
        private readonly IIdGenerator _idGenerator;

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityHelper"/> class.
        /// </summary>
        /// <param name="idGenerator">The idGenerator<see cref="IIdGenerator"/>.</param>
        public IdentityHelper(IIdGenerator idGenerator)
        {
            EnsureArg.IsNotNull(idGenerator, nameof(idGenerator));

            _idGenerator = idGenerator;
        }

        /// <summary>
        /// Generates the element identifier if empty.
        /// </summary>
        /// <param name="existingId">The existingId<see cref="string"/>.</param>
        /// <param name="newId">The newId<see cref="string"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public string GenerateElementIdIfEmpty(string existingId, string newId)
        {
            var uid = existingId;
            if (string.IsNullOrWhiteSpace(existingId))
            {
                uid = string.IsNullOrWhiteSpace(newId) ? _idGenerator.Generate : newId;
            }

            return uid;
        }
    }
}
