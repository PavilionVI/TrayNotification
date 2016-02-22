using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

using TrayNotification.Providers;
using TrayNotification.Helpers;

namespace TrayNotification
{
    public class Notification : Form
    {
        /// <summary>
        /// Title for the notification.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The body text of the notification.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// A color model for the notification elements.
        /// </summary>
        public Coloring Color { get; set; }

        /// <summary>
        /// An image and padding for the notification.
        /// </summary>
        public new NotifIcon Icon { get; set; }

        /// <summary>
        /// Padding from the X and Y axis of the working screen area.
        /// </summary>
        public new int Padding { get; set; }

        private Animator _animator;
        private Timer _lifeTimer;

        protected override void CreateHandle()
        {
            base.CreateHandle();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(380, 80);

            this.DoubleBuffered = true;

            var bounds = Screen.PrimaryScreen.WorkingArea;

            this.Location = new Point(bounds.Width -
                (this.Width + Padding), bounds.Height - (this.Height + Padding));

            var dismissButton = new DismissButton(Color)
            {
                Location = new Point(this.Width - 18, 5),
                Font = this.Font
            };

            this.Controls.Add(dismissButton);
            dismissButton.BringToFront();
        }

        /// <summary>
        /// Initializes the notification and starts animation.
        /// </summary>
        /// <param name="animation">Style of animation to play</param>
        /// <param name="direction">Entrance direction. Exit direction is computed automatically.</param>
        /// <param name="duration">Duration of the animation.</param>
         public Notification(Style animation, Direction direction, int duration)
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
            
            this.TopMost = true;
            this.ShowInTaskbar = false;

            this.Shown += new EventHandler(Form_Shown);

            _animator = new Animator(this)
            {
                Animation = animation,
                Direction = direction,
                Duration = duration
            };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;

            var formatter = new StringFormat()
            {
                FormatFlags = StringFormatFlags.LineLimit,
                Trimming = StringTrimming.EllipsisCharacter
            };
            
            e.Graphics.Clear(Color.BackColor);
            e.Graphics.FillRectangle(new SolidBrush(Color.Tile),
                                        new Rectangle(0, 0, this.Height, this.Height));

            using (var scaledImage = ImageResize.ScaleImage(Icon, this.Width, this.Height))
            {
                var posX = (this.Height - scaledImage.Width) / 2;
                var posY = (this.Height - scaledImage.Height) / 2;

                e.Graphics.DrawImage(scaledImage, posX, posY);
            }
            
            e.Graphics.DrawString(Title, new Font("Arial", 12, FontStyle.Bold), Color.Body, 100, 10);
            e.Graphics.DrawString(Body, new Font("Arial", 8, FontStyle.Regular), Color.Body,
                                new RectangleF(100, 40, (this.Width - 100), this.Height));
        }

        /// <summary>
        /// Shows the notification for a set amount of time.
        /// </summary>
        /// <param name="delay">Time in milliseconds to display before dismissal.</param>
        public void Show(int delay)
        {
            base.Show();

            if (delay != 0)
            {
                _lifeTimer = new Timer
                {
                    Interval = delay
                };

                _lifeTimer.Tick += new EventHandler(Form_Close);

                this.MouseEnter += new EventHandler(Mouse_Enter);
                this.MouseLeave += new EventHandler(Mouse_Leave);

                _lifeTimer.Start();
            }
        }

        /// <summary>
        /// Dismisses the form regardless of input or remaining time.
        /// </summary>
        /// <param name="instant">Whether to immediately close or go through the closing animation.</param>
        public void Dismiss(bool instant)
        {
            if (instant)
                base.Hide();

            base.Close();
        }

        private void Mouse_Enter(object sender, EventArgs e)
        {
            _lifeTimer.Stop();
        }

        private void Mouse_Leave(object sender, EventArgs e)
        {
            _lifeTimer.Start();
        }

        private void Form_Shown(object sender, EventArgs e)
        {
            _animator.Direction = Sibling.GetSiblingDirection(_animator.Direction);
        }

        private void Form_Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}