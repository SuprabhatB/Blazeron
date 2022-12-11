namespace Blazeron.Utilities.Constants
{
    using Blazeron.Utilities.Extensions;

    using System.Runtime.CompilerServices;

    /// <summary>
    /// Defines the <see cref="JSConstants" />.
    /// </summary>
    public class JSConstants
    {
        /// <summary>
        /// The GetValue.
        /// </summary>
        /// <param name="name">The name<see cref="string"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        internal static string GetValue([CallerMemberName] string name = null)
        {
            return $"BlazeronJSService.{name.ToCamelCase()}";
        }

        /// <summary>
        /// Gets the logger.
        /// </summary>
        /// <value>
        /// The logger.
        /// </value>
        public static string Logger => GetValue();

        /// <summary>
        /// Gets the toggle sidebar.
        /// </summary>
        /// <value>
        /// The toggle sidebar.
        /// </value>
        public static string ToggleSidebar => GetValue();

        /// <summary>
        /// Gets the toggle sidebar menu.
        /// </summary>
        /// <value>
        /// The toggle sidebar menu.
        /// </value>
        public static string ToggleSidebarMenu => GetValue();

        /// <summary>
        /// Gets the height of the set automatic.
        /// </summary>
        /// <value>
        /// The height of the set automatic.
        /// </value>
        public static string SetAutoHeight => GetValue();

        /// <summary>
        /// Gets the size of the set section.
        /// </summary>
        /// <value>
        /// The size of the set section.
        /// </value>
        public static string SetSectionSize => GetValue();

        /// <summary>
        /// Gets the hash scroll.
        /// </summary>
        /// <value>
        /// The hash scroll.
        /// </value>
        public static string HashScroll => GetValue();


        /// <summary>
        /// Gets the add to browser history.
        /// </summary>
        /// <value>
        /// The add to browser history.
        /// </value>
        public static string AddToBrowserHistory => GetValue();
    }
}
