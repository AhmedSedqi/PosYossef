using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PosYossef
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // أنشئ النافذة الرئيسية وعرضها مرة واحدة فقط
            var mainWindow = new MainWindow();
            mainWindow.Show();

            // تأكد من إغلاق التطبيق عند إغلاق النافذة الرئيسية
            mainWindow.Closed += (s, args) => this.Shutdown();
        }
    }


}
