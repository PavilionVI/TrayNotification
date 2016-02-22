using System;
using System.Drawing;

namespace TrayNotification.Helpers
{
    public class ImageResize
    {
        public static Image ScaleImage(NotifIcon icon, int width, int height)
        {
            var adjustX = (double)width / icon.Image.Width;
            var adjustY = (double)height / icon.Image.Height;

            var ratio = Math.Min(adjustX, adjustY);

            var newWidth = (int)(icon.Image.Width * ratio) - icon.Padding;
            var newHeight = (int)(icon.Image.Height * ratio) - icon.Padding;

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(icon.Image, 0, 0, newWidth, newHeight);

            return newImage;
        }
    }
}
