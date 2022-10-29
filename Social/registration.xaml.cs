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

namespace Social
{
    /// <summary>
    /// Логика взаимодействия для registration.xaml
    /// </summary>
    public partial class registration : Window
    {
        public registration()
        {
            InitializeComponent();


            SignIn.Navigate(new LoginPage());
            FrameLoad.MainFrame = SignIn;
           
        }

        private void SignIn_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SignIn.Navigate(new RegistrPage()); // открытие страницы
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SignIn.Navigate(new LoginPage()); // открытие страницы
        }
    }
}
