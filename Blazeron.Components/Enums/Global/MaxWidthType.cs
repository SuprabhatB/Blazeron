namespace Blazeron.Components.Enums
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Control when your layout can be adapted at a particular viewport or device size.
    /// </summary>
    public enum MaxWidthType
    {
        /// <summary>
        /// The sm - Small (dimensions: ≥576px)
        /// </summary>
        [Display(Name = "sm")]
        SM,

        /// <summary>
        /// The md - Medium (dimensions: ≥768px)
        /// </summary>
        [Display(Name = "md")]
        MD,

        /// <summary>
        /// The lg - Large (dimensions: ≥992px)
        /// </summary>
        [Display(Name = "lg")]
        LG,

        /// <summary>
        /// The xl - Extra large (dimensions: ≥1200px)
        /// </summary>
        [Display(Name = "xl")]
        XL,

        /// <summary>
        /// The XXL - Extra extra large (dimensions: ≥1400px)
        /// </summary>
        [Display(Name = "xxl")]
        XXL
    }
}
