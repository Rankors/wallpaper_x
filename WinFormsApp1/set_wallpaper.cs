using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.wallpapers;
using System;
using Microsoft.Web.WebView2.Wpf;
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class set_wallpaper : UserControl
    {
        #region dll
        [DllImport("set_wallpapers.dll")]
        public static extern bool set(IntPtr hwnd);


        #endregion

        enum window
        {
            None = 0,
            web = 1, 
            video = 2,
            photo =3
        }

        private System.Windows.Forms.Timer mouseMoveTimer;
        window selectedWindow;
        WebWallpaper wallpaper;
        public video_wallpaper video;
        IntPtr hwnd = IntPtr.Zero;

        public set_wallpaper()
        {
            selectedWindow = window.None;
            InitializeComponent();
        }
        #region html
        private void set_html_Click(object sender, EventArgs e)
        {
            close_wallpaper_Click(sender, e);
            wallpaper = new WebWallpaper();
            hwnd = wallpaper.Handle;
            Microsoft.Web.WebView2.WinForms.WebView2 web = wallpaper._web();
            if (!string.IsNullOrEmpty(URL_html.Text))
            {
                web.Source = new Uri(URL_html.Text);
                wallpaper.Show();
                // set() это функция из моей dll, оно ставит окно в качестве фона рабочего стола
                if (set(hwnd))
                {
                    wallpaper.WindowState = FormWindowState.Maximized;
                    selectedWindow = window.web;
                    
                }
            }
        }
        #endregion
        private void close_wallpaper_Click(object sender, EventArgs e)
        {
            switch (selectedWindow)
            {
                case window.None: break;
                case window.web:
                    wallpaper.Close();
                    break;
                case window.video:
                    video.Close();
                    break;
                case window.photo:break;
            }
            selectedWindow= window.None;
        }
        #region video wallpaper
        private void select_video_Click(object sender, EventArgs e)
        {
            close_wallpaper_Click(sender, e);
            string path;
            video_file_select.ShowDialog();
            video_file_select.Filter = "Видео файлы (*.mp4; *.avi; *.mkv)|*.mp4; *.avi; *.mkv";
            path = video_file_select.FileName;

            show_video(path);
        }

        void show_video(string path)
        {

            video = new video_wallpaper();            
            video.Show();
            hwnd = video.Handle;
            if (set(hwnd))
            {
                selectedWindow = window.video;
                video.WindowState = FormWindowState.Maximized;
                video.set_video(path);
            }
        }

        private void video_set_url_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(youtube_video.Text))
            {
                close_wallpaper_Click(sender, e);
                show_video(youtube_video.Text);
            }
        }


        #endregion

        public void set_volume(int i)
        {
            video.videoView1.MediaPlayer.Volume = i;
        }
    }




}
