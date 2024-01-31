using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.wallpapers;
using Newtonsoft.Json;

namespace WinFormsApp1
{
    public partial class settings_menu : UserControl
    {
        
        public bool mouse_hook, play_back, all_in_1;
        public int default_value = 0, value;
        public settings_menu()
        {
            InitializeComponent();
            preLoad();
            volume_lbl.Text = "Volume " + volume_slider.Value.ToString() + "%";
            Application.ApplicationExit += when_app_exit;
        }
        #region settings btn
        public void volume_slider_ValueChanged(object sender, EventArgs e)
        {
            value = volume_slider.Value;
            volume_lbl.Text ="Volume " + value.ToString() + "%";
        }
        private void mouse_hook_check_CheckedChanged(object sender, EventArgs e)
        {
            mouse_hook = !mouse_hook;
        }
        private void play_back_check_CheckedChanged(object sender, EventArgs e)
        {
            play_back = !play_back;
        }
        private void all_desktop_in1_check_CheckedChanged(object sender, EventArgs e)
        {
            all_in_1 = !all_in_1;
        }
        
        #endregion
        void preLoad()
        {
            var _settings = File.Exists("settings_.json") ? JsonConvert.DeserializeObject<settings>(File.ReadAllText("settings_.json")) : new settings
            {
                volume = volume_slider.Value,
                mouse_hook = this.mouse_hook,
                play_back = this.play_back,
                all_desk_in_1 = all_in_1
            };
            volume_slider.Value = _settings.volume;
        }

        public void when_app_exit(object sender, EventArgs e)
        {
            var _settings = new settings
            {
                volume = volume_slider.Value,
                mouse_hook = this.mouse_hook,
                play_back = this.play_back,
                all_desk_in_1 = all_in_1
            };
            File.WriteAllText("settings_.json", JsonConvert.SerializeObject(_settings));
        }

    }

    public class settings
    {
        public int volume { get; set;}
        public bool mouse_hook { get; set; }
        public bool play_back { get; set; }
        public bool all_desk_in_1 { get; set; }
    }
}
