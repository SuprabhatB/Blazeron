namespace Blazeron.Components.Enums
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Predefined button styles, each serving its own semantic purpose, with a few extras thrown in for more control.
    /// </summary>
    public enum ButtonVariantType
    {
        /// <summary>
        /// The none
        /// </summary>
        None,

        /// <summary>
        /// The default
        /// </summary>
        [Display(Name = "default")]
        Default,

        /// <summary>
        /// The primary
        /// </summary>
        [Display(Name = "primary")]
        Primary,

        /// <summary>
        /// The secondary
        /// </summary>
        [Display(Name = "secondary")]
        Secondary,

        /// <summary>
        /// The success
        /// </summary>
        [Display(Name = "success")]
        Success,

        /// <summary>
        /// The danger
        /// </summary>
        [Display(Name = "danger")]
        Danger,

        /// <summary>
        /// The warning
        /// </summary>
        [Display(Name = "warning")]
        Warning,

        /// <summary>
        /// The information
        /// </summary>
        [Display(Name = "info")]
        Info,

        /// <summary>
        /// The light
        /// </summary>
        [Display(Name = "light")]
        Light,
        
        /// <summary>
        /// The dark
        /// </summary>
        [Display(Name = "dark")]
        Dark,

        /// <summary>
        /// The link
        /// </summary>
        [Display(Name = "link")]
        Link
    }
}
