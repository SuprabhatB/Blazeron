namespace Blazeron.Components.Enums
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Defines the table align type.
    /// </summary>
    public enum TableAlignType
    {
        /// <summary>
        /// The none
        /// </summary>
        None,

        /// <summary>
        /// The top
        /// </summary>
        [Display(Name = "top")]
        Top,

        /// <summary>
        /// The middle
        /// </summary>
        [Display(Name = "middle")]
        Middle,

        /// <summary>
        /// The bottom
        /// </summary>
        [Display(Name = "bottom")]
        Bottom
    }
}
