using System.Drawing;

namespace TrayNotification
{
    public class NotifIcon
    {
        /// <summary>
        /// An image to use as the icon, will be resized automatically.
        /// </summary>
        public Image Image { get; set; }

        /// <summary>
        /// Padding between the image and the notification border.
        /// </summary>
        public int Padding { get; set; }
    }
}