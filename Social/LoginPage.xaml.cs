using MySql.Data.MySqlClient;
using Renci.SshNet.Messages.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        Config db = new Config();
        //connection con = new connection();
        string id, name, email, numberco, password;

        public LoginPage()
        {
            InitializeComponent();
            // pass the database you want to connect to
            db.Connect("shopping");

        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Php authorizations

            var loginuser = txtLogin.Text;
            var password = md5.hashPassword(boxpassword.Password);
            // query MySQL database for the data passed from text boxes
            db.ExecuteSelect("SELECT * FROM `meneger` where username='" + txtLogin.Text + "' and password ='" + password + "'");
            if (db.Count() == 1)
            {

                MessageBox.Show("Вы зашли как " + db.Results(0, "username"));
                MainWindow MainWindow = new MainWindow();
                MainWindow.Show();
                

            }
            else
            {
                MessageBox.Show("Не правильный логин или пароль");
            }




            //C# authorizations

            //auth currentUser = bdconnect.db.auth.FirstOrDefault(x => x.login == txtLogin.Text && x.password == boxpassword.Password);
            //if (currentUser != null)
            //{
            //    switch (currentUser.idrole)
            //    {
            //        case 1:
            //            MessageBox.Show("Вход администратора");

            //           // FrameLoad.MainFrame.Navigate(new HomeView());
            //            break;
            //        case 2:
            //            MessageBox.Show("Вход пользователя");
            //            //FrameLoad.MainFrame.Navigate(new HomeView(currentUser));
            //            break;
            //        default:
            //            MessageBox.Show("Неизвестная роль в системе");
            //            break;
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("Нет такого пользователя");
            //}



           



        }




    }
}
