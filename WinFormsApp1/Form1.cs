using Bunifu.Framework.UI;
using WinFormsApp1.wallpapers;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        video_wallpaper video;
        WebWallpaper web;
        settings_menu settings;
        set_wallpaper set;
        Point mouse_loc;
        public Form1()
        {
            InitializeComponent();
            this.notifyIcon1.Icon = this.Icon; // Задать значок в области уведомлений
            this.notifyIcon1.MouseClick += new MouseEventHandler(notifyIcon1_MouseClick);
            this.Padding = new Padding(1);
            
        }
        private void s_settings_Click(object sender, EventArgs e)
        {
            shows.Controls.Clear();
            settings = new settings_menu();
            shows.Controls.Add(settings);
            settings.Dock = DockStyle.Fill;
            ///
            BunifuTrackbar slider = settings.volume_slider;
            slider.ValueChanged += volume_track;
        }

        private void s_set_Click(object sender, EventArgs e)
        {
            shows.Controls.Clear();
            set = new set_wallpaper();
            shows.Controls.Add(set);
            set.Dock = DockStyle.Fill;
        }

        #region settings
        void volume_track(Object sender, EventArgs e)
        {
            BunifuTrackbar slider = (BunifuTrackbar)sender;
            if (set != null)
            {
                set.set_volume(slider.Value);
            }
        }
        #endregion
        #region custom form border
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Если щелчок левой кнопкой мыши
            {
                this.Show();
                this.ShowInTaskbar = true;
            }
        }
        private void minimaze_btn_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            this.Hide();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_loc = new Point(-e.X, -e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mouse_pos = Control.MousePosition;
                mouse_pos.Offset(mouse_loc.X, mouse_loc.Y);
                Location= mouse_pos;
            }
        }

        private void maximize_btn_Click(object sender, EventArgs e)
        {
            this.MaximumSize = Screen.FromHandle(this.Handle).WorkingArea.Size;
            this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        protected override void WndProc(ref Message m)
        {
            const int wmNcHitTest = 0x84;
            const int htBottomLeft = 16;
            const int htBottomRight = 17;
            if (m.Msg == wmNcHitTest)
            {
                int x = (int)(m.LParam.ToInt64() & 0xFFFF);
                int y = (int)((m.LParam.ToInt64() & 0xFFFF0000) >> 16);
                Point pt = PointToClient(new Point(x, y));
                Size clientSize = ClientSize;
                if (pt.X >= clientSize.Width - 16 && pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htBottomLeft : htBottomRight);
                    return;
                }
            }
            base.WndProc(ref m);
        }


        #endregion

        private void app_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}

/*int primaryWidth = Convert.ToInt32(System.Windows.SystemParameters.PrimaryScreenWidth);
int primaryHeight = Convert.ToInt32(System.Windows.SystemParameters.PrimaryScreenHeight);
SetWindowPos(workerw, HWND.Bottom, 0, 0, (int)primaryWidth, (int)primaryHeight, 0);*/
