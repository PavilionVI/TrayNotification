using System.Drawing;

namespace TrayNotification
{
    public struct Coloring
    {
        /// <summary>
        /// Color of the main title and body text.
        /// </summary>
        public Brush Body { get; set; }

        /// <summary>
        /// The color of the tile used as a backdrop of the image.
        /// </summary>
        public Color Tile { get; set; }

        /// <summary>
        /// Backcolor of the main notification system.
        /// </summary>
        public Color BackColor { get; set; }
    }
}