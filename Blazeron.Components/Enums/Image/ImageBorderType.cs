namespace Blazeron.Components.Enums
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Defines the image border type.
    /// </summary>
    public enum ImageBorderType
    {
        /// <summary>
        /// The none
        /// </summary>
        None,

        /// <summary>
        /// The rounded
        /// </summary>
        [Display(Name = "rounded")]
        Rounded,

        /// <summary>
        /// The rounded circle
        /// </summary>
        [Display(Name = "circle")]
        Circle
    }
}
