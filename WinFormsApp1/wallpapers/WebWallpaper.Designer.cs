﻿namespace WinFormsApp1
{
    partial class WebWallpaper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.webView1 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.webView1)).BeginInit();
            this.SuspendLayout();
            // 
            // webView1
            // 
            this.webView1.AllowExternalDrop = true;
            this.webView1.CreationProperties = null;
            this.webView1.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView1.Location = new System.Drawing.Point(0, 0);
            this.webView1.Name = "webView1";
            this.webView1.Size = new System.Drawing.Size(800, 450);
            this.webView1.TabIndex = 0;
            this.webView1.ZoomFactor = 1D;
            // 
            // WebWallpaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WebWallpaper";
            this.Text = "WebWallpaper";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.close);
            ((System.ComponentModel.ISupportInitialize)(this.webView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView1;
        private System.Windows.Forms.Timer timer1;
    }
}