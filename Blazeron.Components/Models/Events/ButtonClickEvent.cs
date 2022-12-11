namespace Blazeron.Components.Models.Events
{
    using Microsoft.AspNetCore.Components;
    using Microsoft.AspNetCore.Components.Web;

    using System;

    /// <summary>
    /// Defines the <see cref="ButtonClickEvent" />.
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    public class ButtonClickEvent : EventArgs
    {
        /// <summary>
        /// Gets or sets the mouse event.
        /// </summary>
        /// <value>
        /// The mouse event.
        /// </value>
        public MouseEventArgs MouseEvent { get; set; }

        /// <summary>
        /// Gets or sets the element.
        /// </summary>
        /// <value>
        /// The element.
        /// </value>
        public ElementReference Element { get; set; }
    }
}