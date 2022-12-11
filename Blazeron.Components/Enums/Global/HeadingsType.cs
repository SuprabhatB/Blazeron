namespace Blazeron.Components.Enums
{
    using System.ComponentModel.DataAnnotations;

    public enum HeadingsType
    {
        /// <summary>
        /// The none
        /// </summary>
        None,

        /// <summary>
        /// The h1
        /// </summary>
        [Display(Name = "h1")]
        H1,

        /// <summary>
        /// The h2
        /// </summary>
        [Display(Name = "h2")]        
        H2,

        /// <summary>
        /// The h3
        /// </summary>
        [Display(Name = "h3")]        
        H3,

        /// <summary>
        /// The h4
        /// </summary>
        [Display(Name = "h4")]        
        H4,

        /// <summary>
        /// The h5
        /// </summary>
        [Display(Name = "h5")]        
        H5,

        /// <summary>
        /// The h6
        /// </summary>
        [Display(Name = "h6")]        
        H6
    }
}
