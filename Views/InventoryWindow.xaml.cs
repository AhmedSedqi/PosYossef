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

        private void POSButton_Click(object sender, RoutedEventArgs e)
        {
            var posWindow = new POSWindow();

            // تعيين نفس موقع وقياس النافذة الرئيسية
            posWindow.Left = this.Left;
            posWindow.Top = this.Top;
            posWindow.Width = this.Width;
            posWindow.Height = this.Height;
            posWindow.WindowState = this.WindowState;

            // إخفاء النافذة الحالية بعد تحميل النافذة الجديدة
            posWindow.Loaded += (s, args) => this.Hide();

            // إعادة عرض النافذة الرئيسية عند إغلاق نافذة البيع
            posWindow.Closed += (s, args) => this.Show();

            posWindow.Show();
        }
    }
}
