namespace Blazeron.Components.Enums
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Defines the SpacingType.
    /// </summary>
    public enum SpacingType
    {
        /// <summary>
        /// The none
        /// </summary>
        None,

        /// <summary>
        /// The top only
        /// </summary>
        [Display(Name = "reset-pad-top")]
        TopOnly,

        /// <summary>
        /// The right only
        /// </summary>
        [Display(Name = "reset-pad-right")]
        RightOnly,

        /// <summary>
        /// The bottom only
        /// </summary>
        [Display(Name = "reset-pad-bottom")]
        BottomOnly,

        /// <summary>
        /// The left only
        /// </summary>
        [Display(Name = "reset-pad-left")]
        LeftOnly,

        /// <summary>
        /// The top right
        /// </summary>
        [Display(Name = "reset-pad-top-right")]
        TopRight,

        /// <summary>
        /// The top bottom
        /// </summary>
        [Display(Name = "reset-pad-top-bottom")]
        TopBottom,

        /// <summary>
        /// The top left
        /// </summary>
        [Display(Name = "reset-pad-top-left")]
        TopLeft,

        /// <summary>
        /// The left bottom
        /// </summary>
        [Display(Name = "reset-pad-left-bottom")]
        LeftBottom,

        /// <summary>
        /// The left right
        /// </summary>
        [Display(Name = "reset-pad-left-right")]
        LeftRight,

        /// <summary>
        /// The right bottom
        /// </summary>
        [Display(Name = "reset-pad-right-bottom")]
        RightBottom,

        /// <summary>
        /// The top right bottom
        /// </summary>
        [Display(Name = "reset-pad-top-right-bottom")]
        TopRightBottom,

        /// <summary>
        /// The top right left
        /// </summary>
        [Display(Name = "reset-pad-top-right-left")]
        TopRightLeft,

        /// <summary>
        /// The top bottom left
        /// </summary>
        [Display(Name = "reset-pad-top-bottom-left")]
        TopBottomLeft,

        /// <summary>
        /// The right bottom left
        /// </summary>
        [Display(Name = "reset-pad-right-bottom-left")]
        RightBottomLeft,

        /// <summary>
        /// All
        /// </summary>
        [Display(Name = "reset-pad-right")]
        All
    }
}
