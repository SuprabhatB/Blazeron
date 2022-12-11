namespace Blazeron.Components.Enums
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Defines the ButtonSizeType.
    /// </summary>
    public enum ButtonSizeType
    {
        /// <summary>
        /// The none
        /// </summary>
        None,

        /// <summary>
        /// The sm
        /// </summary>
        [Display(Name = "xs")]
        ExtraSmall,

        /// <summary>
        /// The sm
        /// </summary>
        [Display(Name = "sm")]
        Small,

        /// <summary>
        /// The sm
        /// </summary>
        [Display(Name = "md")]
        Medium,

        /// <summary>
        /// The lg
        /// </summary>
        [Display(Name = "lg")]
        Large,

        /// <summary>
        /// The lg
        /// </summary>
        [Display(Name = "xl")]
        ExtraLarge,
    }
}
