namespace Blazeron.Components.Enums
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Defines the button type.
    /// </summary>
    public enum ButtonType
    {
        /// <summary>
        /// The button
        /// </summary>
        [Display(Name = "button")]
        Button,

        /// <summary>
        /// The submit
        /// </summary>
        [Display(Name = "submit")]
        Submit,

        /// <summary>
        /// The reset
        /// </summary>
        [Display(Name = "reset")]
        Reset
    }
}
