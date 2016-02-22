namespace TrayNotification
{
    public enum Style
    {
        /// <summary>
        /// Slides out from edge when showing and slides into edge when hiding.
        /// </summary>
        /// <remarks>
        /// Requires a direction.
        /// </remarks>
        Slide = 0x40000,

        /// <summary>
        /// Fades from transaprent to opaque when showing and from opaque to transparent when hiding.
        /// </summary>
        Fade = 0x80000
    }
}