namespace Blazeron.Model
{
    /// <summary>
    /// Defines the <see cref="ListItemModel{T}" />.
    /// </summary>
    /// <typeparam name="T">.</typeparam>
    public class ListItemModel<T>
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public T Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }
    }
}
