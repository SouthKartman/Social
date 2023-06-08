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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();




            frmMain.Navigate(new HomeView());
            FrameLoad.MainFrame = frmMain;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Gmail Gmail = new Gmail();
            Gmail.Show();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            registration registration = new registration();
            registration.Show();
            Close();
        }

      

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var response = MessageBox.Show("Вы точно хотите выйти?", "Выход...",
                                    MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            if (response == MessageBoxResult.No)
            {
                
            }
            else
            {
                Application.Current.Shutdown();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            frmMain.Navigate(new HomeView());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            frmMain.Navigate(new WorkedPlace()); // открытие страницы
            
        }

        private void frmMain_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            //Process.Start("http://localhost/shopping/meneger/index.php");
            frmMain.Navigate(new Meneger()); // открытие страни

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            frmMain.Navigate(new Gallery()); // открытие страницы
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Process.Start("https://mail.google.com/mail");
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Process.Start("http://localhost/shopping/introduce/intro.html");
        }
    }
}
