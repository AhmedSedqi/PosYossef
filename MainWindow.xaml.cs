using PosYossef.Views;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PosYossef
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InventoryButton_Click(object sender, RoutedEventArgs e)
        {
            var inventoryWindow = new InventoryWindow();

            // تعيين نفس موقع وقياس النافذة الرئيسية
            inventoryWindow.Left = this.Left;
            inventoryWindow.Top = this.Top;
            inventoryWindow.Width = this.Width;
            inventoryWindow.Height = this.Height;
            inventoryWindow.WindowState = this.WindowState; // للحفاظ على حالة التكبير/التصغير

            // إخفاء النافذة الحالية بعد تحميل النافذة الجديدة
            inventoryWindow.Loaded += (s, args) => this.Hide();

            inventoryWindow.Show();
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
