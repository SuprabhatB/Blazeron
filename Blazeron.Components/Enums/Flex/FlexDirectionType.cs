namespace Blazeron.Components.Enums
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Defines the flex direction type.
    /// </summary>
    public enum FlexDirectionType
    {
        /// <summary>
        /// The none
        /// </summary>
        None,

        /// <summary>
        /// The default
        /// </summary>
        Default,

        /// <summary>
        /// The reverse
        /// </summary>
        [Display(Name = "reverse")]
        Reverse
    }
}
