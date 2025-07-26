using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PosYossef.Views
{
    /// <summary>
    /// Interaction logic for InventoryWindow.xaml
    /// </summary>
    public partial class InventoryWindow : Window
    {
        public InventoryWindow()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            // استعادة النافذة الرئيسية عند الإغلاق
            var mainWindow = Application.Current.MainWindow;
            mainWindow.Left = this.Left;
            mainWindow.Top = this.Top;
            mainWindow.Width = this.Width;
            mainWindow.Height = this.Height;
            mainWindow.WindowState = this.WindowState;
            mainWindow.Show();

            base.OnClosed(e);
        }

        private void SearchTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (SearchTextBox.Text == "... بحث")
            {
                SearchTextBox.Text = "";
            }
        }

        private void SearchTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchTextBox.Text))
            {
                SearchTextBox.Text = "... بحث";
            }
        }

        // في ملف Code-Behind
        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SearchTextBox.Text != "... بحث")
            {
                // سيتم تنفيذ البحث هنا لاحقاً
            }
        }
    }
}
