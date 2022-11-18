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

namespace Social
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {


            auth currentUser = bdconnect.db.auth.FirstOrDefault(x => x.login == txtLogin.Text && x.password == boxpassword.Password);
            if (currentUser != null)
            {
                switch (currentUser.idrole)
                {
                    case 1:
                        MessageBox.Show("Вход администратора");
                        
                       // FrameLoad.MainFrame.Navigate(new HomeView());
                        break;
                    case 2:
                        MessageBox.Show("Вход пользователя");
                        //FrameLoad.MainFrame.Navigate(new HomeView(currentUser));
                        break;
                    default:
                        MessageBox.Show("Неизвестная роль в системе");
                        break;
                }

            }
            else
            {
                MessageBox.Show("Нет такого пользователя");
            }
        }
    }
}
