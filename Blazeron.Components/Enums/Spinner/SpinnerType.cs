namespace Blazeron.Components.Enums
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Defines the spinner type.
    /// </summary>
    public enum SpinnerType
    {
        /// <summary>
        /// The border only
        /// </summary>
        [Display(Name = "border")]
        BorderOnly,

        /// <summary>
        /// The grow only
        /// </summary>
        [Display(Name = "grow")]
        GrowOnly
    }
}
