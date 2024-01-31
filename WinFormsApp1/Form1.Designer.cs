namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.border_panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.maximize_btn = new System.Windows.Forms.Button();
            this.Close_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.main = new System.Windows.Forms.Panel();
            this.bodys = new System.Windows.Forms.Panel();
            this.shows = new System.Windows.Forms.Panel();
            this.btn_pnl = new System.Windows.Forms.Panel();
            this.s_set = new System.Windows.Forms.Button();
            this.app_exit = new System.Windows.Forms.Button();
            this.s_settings = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.border_panel.SuspendLayout();
            this.main.SuspendLayout();
            this.bodys.SuspendLayout();
            this.btn_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // border_panel
            // 
            this.border_panel.BackColor = System.Drawing.Color.DimGray;
            this.border_panel.Controls.Add(this.button1);
            this.border_panel.Controls.Add(this.maximize_btn);
            this.border_panel.Controls.Add(this.Close_btn);
            this.border_panel.Controls.Add(this.label1);
            this.border_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.border_panel.Location = new System.Drawing.Point(0, 0);
            this.border_panel.Name = "border_panel";
            this.border_panel.Size = new System.Drawing.Size(600, 40);
            this.border_panel.TabIndex = 0;
            this.border_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.border_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::WinFormsApp1.Properties.Resources.minimize;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(480, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(1);
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.minimaze_btn_Click);
            // 
            // maximize_btn
            // 
            this.maximize_btn.BackColor = System.Drawing.Color.Transparent;
            this.maximize_btn.BackgroundImage = global::WinFormsApp1.Properties.Resources.maximize;
            this.maximize_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maximize_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.maximize_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.maximize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximize_btn.ForeColor = System.Drawing.Color.White;
            this.maximize_btn.Location = new System.Drawing.Point(520, 0);
            this.maximize_btn.Margin = new System.Windows.Forms.Padding(5);
            this.maximize_btn.Name = "maximize_btn";
            this.maximize_btn.Padding = new System.Windows.Forms.Padding(1);
            this.maximize_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.maximize_btn.Size = new System.Drawing.Size(40, 40);
            this.maximize_btn.TabIndex = 2;
            this.maximize_btn.UseVisualStyleBackColor = false;
            this.maximize_btn.Click += new System.EventHandler(this.maximize_btn_Click);
            // 
            // Close_btn
            // 
            this.Close_btn.BackColor = System.Drawing.Color.Transparent;
            this.Close_btn.BackgroundImage = global::WinFormsApp1.Properties.Resources.close;
            this.Close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_btn.ForeColor = System.Drawing.Color.White;
            this.Close_btn.Location = new System.Drawing.Point(560, 0);
            this.Close_btn.Margin = new System.Windows.Forms.Padding(5);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Padding = new System.Windows.Forms.Padding(1);
            this.Close_btn.Size = new System.Drawing.Size(40, 40);
            this.Close_btn.TabIndex = 2;
            this.Close_btn.UseVisualStyleBackColor = false;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wallpaper X";
            // 
            // main
            // 
            this.main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.main.Controls.Add(this.bodys);
            this.main.Controls.Add(this.border_panel);
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Location = new System.Drawing.Point(0, 0);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(600, 400);
            this.main.TabIndex = 1;
            // 
            // bodys
            // 
            this.bodys.AutoSize = true;
            this.bodys.Controls.Add(this.shows);
            this.bodys.Controls.Add(this.btn_pnl);
            this.bodys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodys.Location = new System.Drawing.Point(0, 40);
            this.bodys.Name = "bodys";
            this.bodys.Size = new System.Drawing.Size(600, 360);
            this.bodys.TabIndex = 1;
            // 
            // shows
            // 
            this.shows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shows.Location = new System.Drawing.Point(0, 40);
            this.shows.Name = "shows";
            this.shows.Padding = new System.Windows.Forms.Padding(1);
            this.shows.Size = new System.Drawing.Size(600, 320);
            this.shows.TabIndex = 1;
            // 
            // btn_pnl
            // 
            this.btn_pnl.Controls.Add(this.s_set);
            this.btn_pnl.Controls.Add(this.app_exit);
            this.btn_pnl.Controls.Add(this.s_settings);
            this.btn_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_pnl.Location = new System.Drawing.Point(0, 0);
            this.btn_pnl.Name = "btn_pnl";
            this.btn_pnl.Size = new System.Drawing.Size(600, 40);
            this.btn_pnl.TabIndex = 0;
            // 
            // s_set
            // 
            this.s_set.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.s_set.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.s_set.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.s_set.ForeColor = System.Drawing.Color.White;
            this.s_set.Location = new System.Drawing.Point(186, 0);
            this.s_set.Name = "s_set";
            this.s_set.Size = new System.Drawing.Size(109, 40);
            this.s_set.TabIndex = 0;
            this.s_set.Text = "Wallpaper";
            this.s_set.UseVisualStyleBackColor = true;
            this.s_set.Click += new System.EventHandler(this.s_set_Click);
            // 
            // app_exit
            // 
            this.app_exit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.app_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.app_exit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.app_exit.ForeColor = System.Drawing.Color.White;
            this.app_exit.Location = new System.Drawing.Point(3, 0);
            this.app_exit.Name = "app_exit";
            this.app_exit.Size = new System.Drawing.Size(69, 40);
            this.app_exit.TabIndex = 0;
            this.app_exit.Text = "close";
            this.app_exit.UseVisualStyleBackColor = true;
            this.app_exit.Click += new System.EventHandler(this.app_exit_Click);
            // 
            // s_settings
            // 
            this.s_settings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.s_settings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.s_settings.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.s_settings.ForeColor = System.Drawing.Color.White;
            this.s_settings.Location = new System.Drawing.Point(78, 0);
            this.s_settings.Name = "s_settings";
            this.s_settings.Size = new System.Drawing.Size(102, 40);
            this.s_settings.TabIndex = 0;
            this.s_settings.Text = "Settings";
            this.s_settings.UseVisualStyleBackColor = true;
            this.s_settings.Click += new System.EventHandler(this.s_settings_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.ControlBox = false;
            this.Controls.Add(this.main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.border_panel.ResumeLayout(false);
            this.border_panel.PerformLayout();
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            this.bodys.ResumeLayout(false);
            this.btn_pnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel border_panel;
        private Label label1;
        private Button Close_btn;
        private Button maximize_btn;
        private Panel main;
        private NotifyIcon notifyIcon1;
        private Button button1;
        private Panel bodys;
        private Panel btn_pnl;
        private Panel shows;
        private Button s_settings;
        private Button s_set;
        private Button app_exit;
    }
}