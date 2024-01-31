using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1.wallpapers
{
    public partial class video_wallpaper : Form
    {
        LibVLC LibVLC = new LibVLC();
        MediaPlayer mediaPlayer;
        public video_wallpaper()
        {
            InitializeComponent();         
        }
        public void set_video(string path)
        {
            mediaPlayer = new MediaPlayer(LibVLC);
            var videoView = videoView1;
            videoView.MediaPlayer = mediaPlayer;
            mediaPlayer.Media = new Media(LibVLC, path);
            mediaPlayer.Play();
        }
        void video_wallpaper_closing(object sender, FormClosingEventArgs e)
        {
            mediaPlayer.Stop();
        }

        public void set_volume(int i)
        {
            mediaPlayer.Volume = i;
        }
    }
}
