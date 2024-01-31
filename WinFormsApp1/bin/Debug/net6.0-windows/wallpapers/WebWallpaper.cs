using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Wpf;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Markup;
using WindowsInput;



namespace WinFormsApp1
{
    public partial class WebWallpaper : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public WebWallpaper()
        {
            InitializeComponent();
            timer.Interval= 10;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private async Task SimulateMouseMove(int x, int y)
        {
            try
            {
                // Получаем WebView2 элемент
                Microsoft.Web.WebView2.WinForms.WebView2 webView = webView1;

                // Подключаемся к ядру WebView2
                var coreWebView2 = webView1.CoreWebView2;

                // Вставляем скрипт имитации движения мыши с переданными значениями x и y
                await coreWebView2.ExecuteScriptAsync($@"
            (function() {{
                // Создаем событие движения мыши с переданными значениями x и y
                var event = new MouseEvent('mousemove', {{
                    'view': window,
                    'bubbles': true,
                    'cancelable': true,
                    'clientX': {x},
                    'clientY': {y}
                }});

                // Диспатчим событие движения мыши
                document.dispatchEvent(event);
            }})();
        ");
            }
            catch (Exception ex)
            {
                // Обработка ошибок
            }
        }

        private async void Timer_Tick(object? sender, EventArgs e)
        {
            Point point = System.Windows.Forms.Cursor.Position;
            int x = point.X;
            int y = point.Y;
            
            // Вызываем метод имитации движения мыши
            await SimulateMouseMove(x, y);
        }

        public Microsoft.Web.WebView2.WinForms.WebView2 _web()
        {
            return webView1;
        }

        private void close(object sender, FormClosingEventArgs e)
        {
            timer.Stop();

        }
    }
}


