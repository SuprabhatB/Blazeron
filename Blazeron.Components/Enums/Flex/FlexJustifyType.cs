namespace Blazeron.Components.Enums
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Defines the flex justify type.
    /// </summary>
    public enum FlexJustifyType
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
        /// The end
        /// </summary>
        [Display(Name = "end")]
        End,

        /// <summary>
        /// The center
        /// </summary>
        [Display(Name = "center")]
        Center,

        /// <summary>
        /// The between
        /// </summary>
        [Display(Name = "between")]
        Between,

        /// <summary>
        /// The around
        /// </summary>
        [Display(Name = "around")]
        Around,

        /// <summary>
        /// The evenly
        /// </summary>
        [Display(Name = "start")]
        Evenly,
    }
}
