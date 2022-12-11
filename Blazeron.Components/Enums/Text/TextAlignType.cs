namespace Blazeron.Components.Enums
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Defines the text align type.
    /// </summary>
    public enum TextAlignType
    {
        /// <summary>
        /// The none
        /// </summary>
        None,

        /// <summary>
        /// The start
        /// </summary>
        [Display(Name = "start")]
        Start,

        /// <summary>
        /// The center
        /// </summary>
        [Display(Name = "center")]
        Center,

        /// <summary>
        /// The end
        /// </summary>
        [Display(Name = "end")]
        End,

        /// <summary>
        /// The justify
        /// </summary>
        [Display(Name = "justify")]
        Justify
    }
}
