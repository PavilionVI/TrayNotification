using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

using TrayNotification;

namespace TestForm
{
    public partial class frmMain : Form
    {
        private Notification _notification;

        public frmMain()
        {
            InitializeComponent();
            
            var props = typeof(Color).
                GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);

            foreach (var cb in new[] { cbBackColor, cbTile, cbBody })
                foreach (var prop in props)
                    cb.Items.Add(prop.Name);

            cbFlags.DataSource = Enum.GetValues(typeof(Style));
        }
        
        private void txtIconPath_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog()
            {
                Title = "Tray Notification | Import Image",
                Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png"
            })
                if (ofd.ShowDialog() == DialogResult.OK)
                    txtIconPath.Text = ofd.FileName;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var coloring = new Coloring()
            {
                BackColor = Color.FromName(cbBackColor.SelectedItem.ToString()),
                Tile = Color.FromName(cbTile.SelectedItem.ToString()),

                Body = new SolidBrush(Color.FromName(cbBody.SelectedItem.ToString()))
            };

            var notifIcon = new NotifIcon()
            {
                Image = Image.FromFile(txtIconPath.Text),
                Padding = 10
            };

            _notification = new Notification((Style)cbFlags.SelectedItem, 
                Direction.Up, (int)nudDuration.Value)
            {
                Title = txtTitle.Text,
                Body = txtBody.Text,

                Padding = 10,

                Icon = notifIcon,
                Color = coloring
            };

            if (cbDelay.Checked)
                _notification.ShowWithDelay((int)nudDelay.Value);
            else
                _notification.Show();
        }

        private void btnDismiss_Click(object sender, EventArgs e)
        {
            _notification.Dismiss(cbInstant.Checked);
        }

        private void cbDelay_CheckedChanged(object sender, EventArgs e)
        {
            nudDelay.Enabled = cbDelay.Checked;
        }
    }
}
