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
    /// Логика взаимодействия для RegistrPage.xaml
    /// </summary>
    public partial class RegistrPage : Page
    {
        auth newauth;
        users newusers;
        
        bool redakt;
        public RegistrPage()
        {
            InitializeComponent();

            newauth = new auth();
            newusers = new users();
            redakt = false;

        }
        
        public RegistrPage(auth auth)
        {
            InitializeComponent();
            redakt = true;
            logintext.Text = auth.login;
            users user = bdconnect.db.users.FirstOrDefault(x => x.idauth == auth.id);
            nametext.Text = user.Name;
            sertext.Text = user.Sername;
            
            //DR.SelectedDate = user.birthdate;

            
            newauth = auth;
            newusers = user;
        }
        private void passwordbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void regbtn_Click(object sender, RoutedEventArgs e)
        {
            
            newauth.idrole = 2;
            newauth.login = logintext.Text;
            newauth.password = pb.Text;
            newauth.email = email.Text;
            newauth.sername = sertext.Text;
            newauth.name = nametext.Text;
            if (redakt == false) bdconnect.db.auth.Add(newauth);
            bdconnect.db.SaveChanges();

            newusers.Sername = sertext.Text;
            newusers.Name = nametext.Text;
            newusers.Login = logintext.Text;
            newusers.birthday = (DateTime)DP.SelectedDate;
            newusers.idrole = 2;
            newusers.Email = email.Text;

            newusers.idauth = newauth.id;
            if (redakt == false) bdconnect.db.users.Add(newusers);
            bdconnect.db.SaveChanges();
            MessageBox.Show("Пользователь добавлен");
           
        }

        private void nametext_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
