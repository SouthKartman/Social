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
        public RegistrPage()
        {
            InitializeComponent();

            txtLogin.Text = auth.login;
            users user = bdconnect.socialEntities.users.FirstOrDefault(x => x.idauth == auth.id);
            txtF.Text = user.f;
            txtI.Text = user.i;
            txtO.Text = user.o;
            txtDR.Text = user.birthdate.ToString();
            txtGender.Text = user.genders.gender;
            this.auth = auth;
        }
      
    }
}
