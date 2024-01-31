namespace WinFormsApp1
{
    partial class set_wallpaper
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(set_wallpaper));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.set_html = new Bunifu.Framework.UI.BunifuThinButton2();
            this.URL_html = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.video_set_url = new Bunifu.Framework.UI.BunifuThinButton2();
            this.youtube_video = new System.Windows.Forms.TextBox();
            this.select_video = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.img_set_url = new Bunifu.Framework.UI.BunifuThinButton2();
            this.select_img = new Bunifu.Framework.UI.BunifuThinButton2();
            this.img_url = new System.Windows.Forms.TextBox();
            this.close_wallpaper = new Bunifu.Framework.UI.BunifuThinButton2();
            this.video_file_select = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(26, 47);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(53, 33);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "URL";
            // 
            // set_html
            // 
            this.set_html.ActiveBorderThickness = 1;
            this.set_html.ActiveCornerRadius = 20;
            this.set_html.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.set_html.ActiveForecolor = System.Drawing.Color.White;
            this.set_html.ActiveLineColor = System.Drawing.Color.Red;
            this.set_html.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.set_html.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_html.BackgroundImage")));
            this.set_html.ButtonText = "Set ";
            this.set_html.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.set_html.ForeColor = System.Drawing.Color.SeaGreen;
            this.set_html.IdleBorderThickness = 1;
            this.set_html.IdleCornerRadius = 20;
            this.set_html.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.set_html.IdleForecolor = System.Drawing.Color.White;
            this.set_html.IdleLineColor = System.Drawing.Color.White;
            this.set_html.Location = new System.Drawing.Point(446, 83);
            this.set_html.Margin = new System.Windows.Forms.Padding(5);
            this.set_html.Name = "set_html";
            this.set_html.Size = new System.Drawing.Size(100, 30);
            this.set_html.TabIndex = 1;
            this.set_html.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.set_html.Click += new System.EventHandler(this.set_html_Click);
            // 
            // URL_html
            // 
            this.URL_html.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.URL_html.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.URL_html.ForeColor = System.Drawing.Color.White;
            this.URL_html.Location = new System.Drawing.Point(26, 83);
            this.URL_html.Name = "URL_html";
            this.URL_html.Size = new System.Drawing.Size(410, 29);
            this.URL_html.TabIndex = 2;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(26, 14);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(410, 33);
            this.bunifuCustomLabel2.TabIndex = 0;
            this.bunifuCustomLabel2.Text = "HTML set to background";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(26, 148);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(232, 33);
            this.bunifuCustomLabel3.TabIndex = 0;
            this.bunifuCustomLabel3.Text = "link to video or Select";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(26, 115);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(410, 33);
            this.bunifuCustomLabel4.TabIndex = 0;
            this.bunifuCustomLabel4.Text = "video set to background";
            // 
            // video_set_url
            // 
            this.video_set_url.ActiveBorderThickness = 1;
            this.video_set_url.ActiveCornerRadius = 20;
            this.video_set_url.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.video_set_url.ActiveForecolor = System.Drawing.Color.White;
            this.video_set_url.ActiveLineColor = System.Drawing.Color.Red;
            this.video_set_url.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.video_set_url.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("video_set_url.BackgroundImage")));
            this.video_set_url.ButtonText = "Set ";
            this.video_set_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.video_set_url.ForeColor = System.Drawing.Color.SeaGreen;
            this.video_set_url.IdleBorderThickness = 1;
            this.video_set_url.IdleCornerRadius = 20;
            this.video_set_url.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.video_set_url.IdleForecolor = System.Drawing.Color.White;
            this.video_set_url.IdleLineColor = System.Drawing.Color.White;
            this.video_set_url.Location = new System.Drawing.Point(336, 183);
            this.video_set_url.Margin = new System.Windows.Forms.Padding(5);
            this.video_set_url.Name = "video_set_url";
            this.video_set_url.Size = new System.Drawing.Size(100, 30);
            this.video_set_url.TabIndex = 1;
            this.video_set_url.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.video_set_url.Click += new System.EventHandler(this.video_set_url_Click);
            // 
            // youtube_video
            // 
            this.youtube_video.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.youtube_video.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.youtube_video.ForeColor = System.Drawing.Color.White;
            this.youtube_video.Location = new System.Drawing.Point(26, 184);
            this.youtube_video.Name = "youtube_video";
            this.youtube_video.Size = new System.Drawing.Size(302, 29);
            this.youtube_video.TabIndex = 2;
            // 
            // select_video
            // 
            this.select_video.ActiveBorderThickness = 1;
            this.select_video.ActiveCornerRadius = 20;
            this.select_video.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.select_video.ActiveForecolor = System.Drawing.Color.White;
            this.select_video.ActiveLineColor = System.Drawing.Color.Red;
            this.select_video.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.select_video.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("select_video.BackgroundImage")));
            this.select_video.ButtonText = "Select";
            this.select_video.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.select_video.ForeColor = System.Drawing.Color.SeaGreen;
            this.select_video.IdleBorderThickness = 1;
            this.select_video.IdleCornerRadius = 20;
            this.select_video.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.select_video.IdleForecolor = System.Drawing.Color.White;
            this.select_video.IdleLineColor = System.Drawing.Color.White;
            this.select_video.Location = new System.Drawing.Point(446, 183);
            this.select_video.Margin = new System.Windows.Forms.Padding(5);
            this.select_video.Name = "select_video";
            this.select_video.Size = new System.Drawing.Size(100, 30);
            this.select_video.TabIndex = 1;
            this.select_video.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.select_video.Click += new System.EventHandler(this.select_video_Click);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(26, 251);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(232, 33);
            this.bunifuCustomLabel5.TabIndex = 0;
            this.bunifuCustomLabel5.Text = "link to photo  or Select";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(26, 218);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(410, 33);
            this.bunifuCustomLabel6.TabIndex = 0;
            this.bunifuCustomLabel6.Text = "image set to background";
            // 
            // img_set_url
            // 
            this.img_set_url.ActiveBorderThickness = 1;
            this.img_set_url.ActiveCornerRadius = 20;
            this.img_set_url.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.img_set_url.ActiveForecolor = System.Drawing.Color.White;
            this.img_set_url.ActiveLineColor = System.Drawing.Color.Red;
            this.img_set_url.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.img_set_url.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img_set_url.BackgroundImage")));
            this.img_set_url.ButtonText = "Set ";
            this.img_set_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.img_set_url.ForeColor = System.Drawing.Color.SeaGreen;
            this.img_set_url.IdleBorderThickness = 1;
            this.img_set_url.IdleCornerRadius = 20;
            this.img_set_url.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.img_set_url.IdleForecolor = System.Drawing.Color.White;
            this.img_set_url.IdleLineColor = System.Drawing.Color.White;
            this.img_set_url.Location = new System.Drawing.Point(336, 286);
            this.img_set_url.Margin = new System.Windows.Forms.Padding(5);
            this.img_set_url.Name = "img_set_url";
            this.img_set_url.Size = new System.Drawing.Size(100, 30);
            this.img_set_url.TabIndex = 1;
            this.img_set_url.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // select_img
            // 
            this.select_img.ActiveBorderThickness = 1;
            this.select_img.ActiveCornerRadius = 20;
            this.select_img.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.select_img.ActiveForecolor = System.Drawing.Color.White;
            this.select_img.ActiveLineColor = System.Drawing.Color.Red;
            this.select_img.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.select_img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("select_img.BackgroundImage")));
            this.select_img.ButtonText = "Select";
            this.select_img.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.select_img.ForeColor = System.Drawing.Color.SeaGreen;
            this.select_img.IdleBorderThickness = 1;
            this.select_img.IdleCornerRadius = 20;
            this.select_img.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.select_img.IdleForecolor = System.Drawing.Color.White;
            this.select_img.IdleLineColor = System.Drawing.Color.White;
            this.select_img.Location = new System.Drawing.Point(446, 286);
            this.select_img.Margin = new System.Windows.Forms.Padding(5);
            this.select_img.Name = "select_img";
            this.select_img.Size = new System.Drawing.Size(100, 30);
            this.select_img.TabIndex = 1;
            this.select_img.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // img_url
            // 
            this.img_url.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.img_url.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.img_url.ForeColor = System.Drawing.Color.White;
            this.img_url.Location = new System.Drawing.Point(26, 287);
            this.img_url.Name = "img_url";
            this.img_url.Size = new System.Drawing.Size(302, 29);
            this.img_url.TabIndex = 2;
            // 
            // close_wallpaper
            // 
            this.close_wallpaper.ActiveBorderThickness = 1;
            this.close_wallpaper.ActiveCornerRadius = 20;
            this.close_wallpaper.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.close_wallpaper.ActiveForecolor = System.Drawing.Color.White;
            this.close_wallpaper.ActiveLineColor = System.Drawing.Color.Red;
            this.close_wallpaper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.close_wallpaper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close_wallpaper.BackgroundImage")));
            this.close_wallpaper.ButtonText = "close wallpaper";
            this.close_wallpaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.close_wallpaper.ForeColor = System.Drawing.Color.SeaGreen;
            this.close_wallpaper.IdleBorderThickness = 1;
            this.close_wallpaper.IdleCornerRadius = 20;
            this.close_wallpaper.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.close_wallpaper.IdleForecolor = System.Drawing.Color.White;
            this.close_wallpaper.IdleLineColor = System.Drawing.Color.White;
            this.close_wallpaper.Location = new System.Drawing.Point(408, 17);
            this.close_wallpaper.Margin = new System.Windows.Forms.Padding(5);
            this.close_wallpaper.Name = "close_wallpaper";
            this.close_wallpaper.Size = new System.Drawing.Size(138, 30);
            this.close_wallpaper.TabIndex = 1;
            this.close_wallpaper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.close_wallpaper.Click += new System.EventHandler(this.close_wallpaper_Click);
            // 
            // video_file_select
            // 
            this.video_file_select.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            // 
            // set_wallpaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.img_url);
            this.Controls.Add(this.youtube_video);
            this.Controls.Add(this.URL_html);
            this.Controls.Add(this.select_img);
            this.Controls.Add(this.select_video);
            this.Controls.Add(this.img_set_url);
            this.Controls.Add(this.video_set_url);
            this.Controls.Add(this.close_wallpaper);
            this.Controls.Add(this.set_html);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.MinimumSize = new System.Drawing.Size(600, 320);
            this.Name = "set_wallpaper";
            this.Size = new System.Drawing.Size(600, 320);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 set_html;
        private TextBox URL_html;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuThinButton2 video_set_url;
        private TextBox youtube_video;
        private Bunifu.Framework.UI.BunifuThinButton2 select_video;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuThinButton2 img_set_url;
        private Bunifu.Framework.UI.BunifuThinButton2 select_img;
        private TextBox img_url;
        private Bunifu.Framework.UI.BunifuThinButton2 close_wallpaper;
        private OpenFileDialog video_file_select;
        private System.Windows.Forms.Timer timer1;
    }
}
