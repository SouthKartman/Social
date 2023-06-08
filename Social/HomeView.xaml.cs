using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Social
{
    /// <summary>
    /// Логика взаимодействия для HomeView.xaml
    /// </summary>
    public partial class HomeView : Page
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("Photoshop.exe");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Process.Start("http://localhost/shopping/introduce/intro.html");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Process.Start("https://drive.google.com/"); //открытие ссылки в браузере
        
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Process.Start("https://disk.yandex.ru/"); //открытие ссылки в браузере
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Process.Start("http://localhost/shopping/index.php");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Process.Start("http://localhost/shopping/index.php");
        }
    }
}
