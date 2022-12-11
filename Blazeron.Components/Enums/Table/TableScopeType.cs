namespace Blazeron.Components.Enums
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Defines the table scope type.
    /// </summary>
    public enum TableScopeType
    {
        /// <summary>
        /// The none
        /// </summary>
        None,

        /// <summary>
        /// The col
        /// </summary>
        [Display(Name = "col")]
        Col,

        /// <summary>
        /// The row
        /// </summary>
        [Display(Name = "row")]
        Row,

        /// <summary>
        /// The col group
        /// </summary>
        [Display(Name = "colgroup")]
        ColGroup,

        /// <summary>
        /// The row group
        /// </summary>
        [Display(Name = "rowgroup")]
        RowGroup
    }
}
