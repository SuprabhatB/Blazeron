namespace Blazeron.Components.Enums
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Default, larger or smaller buttons
    /// </summary>
    public enum SizeType
    {
        /// <summary>
        /// The none
        /// </summary>
        None,

        /// <summary>
        /// The sm
        /// </summary>
        [Display(Name = "sm")]
        SM,

        /// <summary>
        /// The md
        /// </summary>
        [Display(Name = "md")]
        MD,

        /// <summary>
        /// The lg
        /// </summary>
        [Display(Name = "lg")]
        LG,

        /// <summary>
        /// The xl
        /// </summary>
        [Display(Name = "xl")]
        XL,

        /// <summary>
        /// The XXL
        /// </summary>
        [Display(Name = "xxl")]
        XXL,

        /// <summary>
        /// The xs
        /// </summary>
        [Display(Name = "xs")]
        XS,

        /// <summary>
        /// The XSS
        /// </summary>
        [Display(Name = "xxs")]
        XSS
    }
}
