namespace Blazeron.Components.Enums
{
    /// <summary>
    /// Containers are a fundamental building block of Bootstrap that contain, pad, and align your content within a given device or viewport.
    /// </summary>
    public enum ContainerType
    {
        /// <summary>
        /// The default - sets a max-width at each responsive breakpoint
        /// </summary>
        Default,

        /// <summary>
        /// The responsive - sets width: 100% until the specified breakpoint
        /// </summary>
        Responsive,

        /// <summary>
        /// The fluid - sets width: 100% at all breakpoints
        /// </summary>
        Fluid
    }
}
