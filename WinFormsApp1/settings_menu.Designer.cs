namespace WinFormsApp1
{
    partial class settings_menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.volume_lbl = new System.Windows.Forms.Label();
            this.volume_slider = new Bunifu.Framework.UI.BunifuTrackbar();
            this.mouse_hook_check = new System.Windows.Forms.CheckBox();
            this.play_back_check = new System.Windows.Forms.CheckBox();
            this.all_desktop_in1_check = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Settings";
            // 
            // volume_lbl
            // 
            this.volume_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.volume_lbl.AutoSize = true;
            this.volume_lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.volume_lbl.ForeColor = System.Drawing.Color.White;
            this.volume_lbl.Location = new System.Drawing.Point(21, 158);
            this.volume_lbl.Name = "volume_lbl";
            this.volume_lbl.Size = new System.Drawing.Size(83, 30);
            this.volume_lbl.TabIndex = 2;
            this.volume_lbl.Text = "Volume";
            // 
            // volume_slider
            // 
            this.volume_slider.BackColor = System.Drawing.Color.Transparent;
            this.volume_slider.BackgroudColor = System.Drawing.Color.DarkGray;
            this.volume_slider.BorderRadius = 0;
            this.volume_slider.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.volume_slider.Location = new System.Drawing.Point(21, 214);
            this.volume_slider.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.volume_slider.MaximumValue = 100;
            this.volume_slider.MinimumValue = 0;
            this.volume_slider.Name = "volume_slider";
            this.volume_slider.Size = new System.Drawing.Size(393, 33);
            this.volume_slider.SliderRadius = 0;
            this.volume_slider.TabIndex = 3;
            this.volume_slider.Value = 0;
            this.volume_slider.ValueChanged += new System.EventHandler(this.volume_slider_ValueChanged);
            // 
            // mouse_hook_check
            // 
            this.mouse_hook_check.AutoSize = true;
            this.mouse_hook_check.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mouse_hook_check.ForeColor = System.Drawing.SystemColors.Control;
            this.mouse_hook_check.Location = new System.Drawing.Point(21, 36);
            this.mouse_hook_check.Name = "mouse_hook_check";
            this.mouse_hook_check.Size = new System.Drawing.Size(375, 29);
            this.mouse_hook_check.TabIndex = 5;
            this.mouse_hook_check.Text = "Control the background with the mouse?";
            this.mouse_hook_check.UseVisualStyleBackColor = true;
            this.mouse_hook_check.CheckedChanged += new System.EventHandler(this.mouse_hook_check_CheckedChanged);
            // 
            // play_back_check
            // 
            this.play_back_check.AutoSize = true;
            this.play_back_check.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.play_back_check.ForeColor = System.Drawing.SystemColors.Control;
            this.play_back_check.Location = new System.Drawing.Point(21, 71);
            this.play_back_check.Name = "play_back_check";
            this.play_back_check.Size = new System.Drawing.Size(334, 29);
            this.play_back_check.TabIndex = 5;
            this.play_back_check.Text = "Play when another window is open?";
            this.play_back_check.UseVisualStyleBackColor = true;
            this.play_back_check.CheckedChanged += new System.EventHandler(this.play_back_check_CheckedChanged);
            // 
            // all_desktop_in1_check
            // 
            this.all_desktop_in1_check.AutoSize = true;
            this.all_desktop_in1_check.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.all_desktop_in1_check.ForeColor = System.Drawing.SystemColors.Control;
            this.all_desktop_in1_check.Location = new System.Drawing.Point(21, 106);
            this.all_desktop_in1_check.Name = "all_desktop_in1_check";
            this.all_desktop_in1_check.Size = new System.Drawing.Size(322, 29);
            this.all_desktop_in1_check.TabIndex = 5;
            this.all_desktop_in1_check.Text = "Setting up each screen separately?";
            this.all_desktop_in1_check.UseVisualStyleBackColor = true;
            this.all_desktop_in1_check.CheckedChanged += new System.EventHandler(this.all_desktop_in1_check_CheckedChanged);
            // 
            // settings_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.mouse_hook_check);
            this.Controls.Add(this.all_desktop_in1_check);
            this.Controls.Add(this.play_back_check);
            this.Controls.Add(this.volume_slider);
            this.Controls.Add(this.volume_lbl);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(600, 320);
            this.Name = "settings_menu";
            this.Size = new System.Drawing.Size(600, 320);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label volume_lbl;
        public Bunifu.Framework.UI.BunifuTrackbar volume_slider;
        private CheckBox mouse_hook_check;
        private CheckBox play_back_check;
        private CheckBox all_desktop_in1_check;
    }
}
